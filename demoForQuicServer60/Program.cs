// See https://aka.ms/new-console-template for more information
using System.IO.Pipelines;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

Console.WriteLine("Hello, World!");

CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

var securityOptions = new System.Net.Security.SslServerAuthenticationOptions
{
    ApplicationProtocols = new List<SslApplicationProtocol>() { new("quictest") },
    ServerCertificate = new X509Certificate(@"cer.pfx", "v0jxmXaFPeXJNsQk"),
};
var listener = new QuicListener(QuicImplementationProviders.MsQuic, IPEndPoint.Parse("127.0.0.1:9999"), securityOptions);

var quicConnection = await listener.AcceptConnectionAsync();
Console.WriteLine("连上了");

while (!cancellationTokenSource.IsCancellationRequested)
{
    var quicStream = await quicConnection.AcceptStreamAsync();
    if (quicStream != null)
    {
        var reader = PipeReader.Create(quicStream);
        var readResult = await reader.ReadAsync();
        var bytes = readResult.Buffer;

        Console.WriteLine(Encoding.UTF8.GetString(bytes));
    }

}
