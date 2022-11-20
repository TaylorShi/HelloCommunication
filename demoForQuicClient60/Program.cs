// See https://aka.ms/new-console-template for more information
using System.Net.Quic;
using System.Net.Security;
using System.Net;
using System.Text;

Console.WriteLine("Hello, World!");

var conn = new QuicConnection(IPEndPoint.Parse("127.0.0.1:9999"), new SslClientAuthenticationOptions()
{
    ApplicationProtocols = new List<SslApplicationProtocol>() { new("quictest") },
});
await conn.ConnectAsync();
var stream = conn.OpenBidirectionalStream();
await stream.WriteAsync(Encoding.UTF8.GetBytes("来自Client"));
Console.ReadLine();