
namespace OpcUaMethodsApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: OpcUaMethodsApp <opcua_server_url>");
                return;
            }

            string serverUrl = args[0];
            string markdownFilePath = "Methods.md";

            var source = new CancellationTokenSource();

            try
            {
                using var client = new OpcUaClient();
                await client.ConnectAsync(serverUrl, source.Token);
                Console.WriteLine($"Connected to {serverUrl}");

                var methods = await client.GetMethodsAsync(source.Token);
                await GenerateMethodsMarkdownFile(markdownFilePath, methods);

                Console.WriteLine($"Methods written to {markdownFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static async Task GenerateMethodsMarkdownFile(string filePath, IReadOnlyList<MethodMetadata> methods)
        {
            using var fileStream = File.Create(filePath);
            using var streamWriter = new StreamWriter(fileStream);

            await streamWriter.WriteLineAsync("# OPC UA Methods");
            await streamWriter.WriteLineAsync("");

            // Write index links
            foreach (var method in methods)
            {
                string anchor = method.Name.Replace(" ", "-");
                streamWriter.WriteLine($"- [{method.Name}](#{anchor})");
            }

            // Write methods header
            streamWriter.WriteLine("\n# Methods\n");

            // Write method details
            foreach (var method in methods)
            {
                string anchor = method.Name.Replace(" ", "-");
                streamWriter.WriteLine($"## <a id='{anchor}'></a>{method.Name}");
                streamWriter.WriteLine($"{method.Description}\n");

                // Write input arguments
                streamWriter.WriteLine("### Input Arguments");
                streamWriter.WriteLine("| Name | Description | Type |");
                streamWriter.WriteLine("|------|-------------|------|");
                foreach (var arg in method.Inputs)
                {
                    streamWriter.WriteLine($"| {arg.Name} | {arg.Description} | {arg.Type} |");
                }

                // Write output arguments
                streamWriter.WriteLine("\n### Output Arguments");
                streamWriter.WriteLine("| Name | Description | Type |");
                streamWriter.WriteLine("|------|-------------|------|");
                foreach (var arg in method.Outputs)
                {
                    streamWriter.WriteLine($"| {arg.Name} | {arg.Description} | {arg.Type} |");
                }

                streamWriter.WriteLine();
                streamWriter.WriteLine("---");
            }
        }
    }
}
