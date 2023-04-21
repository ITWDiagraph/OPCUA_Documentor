using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;

namespace OpcUaMethodsApp
{
    public class MethodMetadata
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ArgumentMetadata> Inputs { get; set; } = new List<ArgumentMetadata>();
        public List<ArgumentMetadata> Outputs { get; set; } = new List<ArgumentMetadata>();
    }

    public class ArgumentMetadata
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }

    public class OpcUaClient : IDisposable
    {
        private Session _session;

        public async Task ConnectAsync(string serverUrl, CancellationToken ct)
        {
            var config = new ApplicationConfiguration
            {
                ApplicationName = "OpcUaMethodsApp",
                ApplicationType = ApplicationType.Client,
                ApplicationUri = Utils.Format("urn:{0}:OpcUaMethodsApp", System.Net.Dns.GetHostName()),
                SecurityConfiguration = new SecurityConfiguration
                {
                    ApplicationCertificate = new CertificateIdentifier { StoreType = "Directory", StorePath = "pki/own", SubjectName = "CN=OpcUaMethodsApp" },
                    TrustedIssuerCertificates = new CertificateTrustList { StoreType = "Directory", StorePath = "pki/trusted" },
                    TrustedPeerCertificates = new CertificateTrustList { StoreType = "Directory", StorePath = "pki/trusted" },
                    RejectedCertificateStore = new CertificateStoreIdentifier { StoreType = "Directory", StorePath = "pki/rejected" },
                    AutoAcceptUntrustedCertificates = true,
                    RejectSHA1SignedCertificates = false,
                    MinimumCertificateKeySize = 1024
                },
                TransportConfigurations = new TransportConfigurationCollection(),
                TransportQuotas = new TransportQuotas { OperationTimeout = 15000 },
                ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 },
                TraceConfiguration = new TraceConfiguration(),
                DisableHiResClock = true
            };
            
            var endpointDescription = CoreClientUtils.SelectEndpoint(serverUrl, false);
            var endpointConfiguration = EndpointConfiguration.Create(config);
            var endpoint = new ConfiguredEndpoint(null, endpointDescription, endpointConfiguration);

            _session = await Session.Create(config, endpoint, false, false, config.ApplicationName, 6000, new UserIdentity(new AnonymousIdentityToken()), null);
            Console.WriteLine($"Session connection state {_session.Connected}");
        }

        public async Task<IReadOnlyList<MethodMetadata>> GetMethodsAsync(CancellationToken ct)
        {
            var methods = new List<MethodMetadata>();

            // Replace the nodeId with the one you're interested in
            var rootNodeId = Objects.ObjectsFolder;

            var browseDescription = new BrowseDescription
            {
                NodeId = rootNodeId,
                BrowseDirection = BrowseDirection.Forward,
                IncludeSubtypes = true,
                NodeClassMask = (uint)NodeClass.Method,
                ResultMask = (uint)BrowseResultMask.All
            };

            var nodesToBrowse = new BrowseDescriptionCollection { browseDescription };

            var response = await _session.BrowseAsync(null, null, 0, nodesToBrowse, ct);

            if (response.Results != null && response.Results.Count > 0)
            {
                var result = response.Results[0];

                foreach (var reference in result.References)
                {
                    // Convert ExpandedNodeId to NodeId
                    NodeId nodeId = ExpandedNodeId.ToNodeId(reference.NodeId, _session.NamespaceUris);
                    if (NodeId.IsNull(nodeId))
                    {
                        Console.WriteLine($"Failed to convert ExpandedNodeId ({reference.NodeId}) to NodeId.");
                        continue;
                    }

                    // Read DisplayName, Description, and InputArguments attributes
                    ReadValueIdCollection nodesToRead = new ReadValueIdCollection
                    {
                        new ReadValueId { NodeId = nodeId, AttributeId = Attributes.DisplayName },
                        new ReadValueId { NodeId = nodeId, AttributeId = Attributes.Description },
                    };

                    DataValueCollection results;
                    DiagnosticInfoCollection diagnosticInfos;
                    _session.Read(null, 0, TimestampsToReturn.Neither, nodesToRead, out results, out diagnosticInfos);

                    // Extract DisplayName, Description, and InputArguments from results
                    LocalizedText displayName = results[0].Value as LocalizedText;
                    LocalizedText description = results[1].Value as LocalizedText;


                    // Create MethodMetadata
                    var methodMetadata = new MethodMetadata
                    {
                        Name = displayName.Text,
                        Description = description.Text,
                    };

                    // Add input arguments to MethodMetadata
                    var (inputArguments, outputArguments) = await GetMethodArguments(nodeId, ct);
                    
                    foreach (var arg in inputArguments)
                    {
                        methodMetadata.Inputs.Add(new ArgumentMetadata
                        {
                            Name = arg.Name,
                            Description = arg.Description.Text,
                            Type = arg.DataType.ToString()
                        });
                    }

                    foreach (var arg in outputArguments)
                    {
                        methodMetadata.Outputs.Add(new ArgumentMetadata
                        {
                            Name = arg.Name,
                            Description = arg.Description.Text,
                            Type = arg.DataType.ToString()
                        });
                    }

                    methods.Add(methodMetadata);

                }

            }

            return methods;
        }

        private async Task<(IList<Argument> inputArguments, IList<Argument> outputArguments)> GetMethodArguments(NodeId methodNodeId, CancellationToken ct)
        {
            // Initialize input and output argument lists
            var inputArguments = new List<Argument>();
            var outputArguments = new List<Argument>();

            // Browse the children of the method node
            var browseDescription = new BrowseDescription
            {
                NodeId = methodNodeId,
                BrowseDirection = BrowseDirection.Forward,
                IncludeSubtypes = true,
                NodeClassMask = (uint)NodeClass.Variable,
                ResultMask = (uint)BrowseResultMask.All
            };

            var nodesToBrowse = new BrowseDescriptionCollection { browseDescription };
            var response = await _session.BrowseAsync(null, null, 0, nodesToBrowse, ct);

            if (response.Results != null && response.Results.Count > 0)
            {
                var result = response.Results[0];

                foreach (var reference in result.References)
                {
                    // Check if the reference is a HasProperty reference
                    if (reference.ReferenceTypeId == ReferenceTypeIds.HasProperty)
                    {
                        NodeId nodeId = ExpandedNodeId.ToNodeId(reference.NodeId, _session.NamespaceUris);
                        if (NodeId.IsNull(nodeId))
                        {
                            Console.WriteLine($"Failed to convert ExpandedNodeId ({reference.NodeId}) to NodeId.");
                            continue;
                        }

                        // Read the value of the input arguments variable
                        var value = await _session.ReadValueAsync(nodeId);

                        if (value.Value is ExtensionObject[] arguments)
                        {
                            // Check if the variable is an input or output argument based on its BrowseName
                            if (reference.BrowseName.Name == "InputArguments")
                            {
                                foreach (var argObj in arguments)
                                {
                                    if (argObj.Body is Argument arg)
                                    {
                                        var dataType = await GetReadableDataType(arg.DataType, ct);
                                        inputArguments.Add(new Argument { Name = arg.Name, Description = arg.Description, DataType = new NodeId(dataType) });
                                    }
                                }
                            }
                            else if (reference.BrowseName.Name == "OutputArguments")
                            {
                                foreach (var argObj in arguments)
                                {
                                    if (argObj.Body is Argument arg)
                                    {
                                        var dataType = await GetReadableDataType(arg.DataType, ct);
                                        outputArguments.Add(new Argument { Name = arg.Name, Description = arg.Description, DataType = new NodeId(dataType) });
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return (inputArguments, outputArguments);
        }

        private async Task<string> GetReadableDataType(NodeId dataTypeId, CancellationToken ct)
        {
            var nodesToRead = new ReadValueIdCollection
            {
                new ReadValueId { NodeId = dataTypeId, AttributeId = Attributes.DisplayName }
            };
            
            var response = await _session.ReadAsync(null, 0, TimestampsToReturn.Neither, nodesToRead, ct);

            if (response.Results != null && response.Results.Count > 0)
            {
                var dataValue = response.Results[0];
                if (dataValue.StatusCode == StatusCodes.Good && dataValue.Value is LocalizedText displayName)
                {
                    return displayName.Text;
                }
            }

            return dataTypeId.ToString();
        }

        public void Dispose()
        {
            _session?.Close();
        }
    }
}
