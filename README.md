# OPC UA Methods Documentor

This is a console application that connects to an OPC UA server and generates a markdown document describing all the methods available in the server. The application uses the [OPC Foundation .NET Standard Stack](https://github.com/OPCFoundation/UA-.NETStandard) to communicate with the server.

## Usage

To use this application, run it from the command line and specify the URL of the OPC UA server as the only argument:

```bash
dotnet run <opcua_server_url>
```

For example:

```bash
dotnet run opc.tcp://localhost:4840
```

The application will connect to the specified server, retrieve information about all the available methods, and generate a markdown document called `Methods.md` in the current directory.

## Dependencies

This application depends on the following packages:

- `Opc.Ua`: The OPC Foundation .NET Standard Stack.
- `Microsoft.Extensions.DependencyInjection`: A dependency injection framework used by the OPC Foundation .NET Standard Stack.

## License

This application is licensed under the [MIT License](LICENSE).