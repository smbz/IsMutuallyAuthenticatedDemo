using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace IsMutuallyAuthenticatedDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            string host = "www.microsoft.com";
            TcpClient client = new TcpClient(host, 443);

            X509Certificate2 clientCertificate = new X509Certificate2(Convert.FromBase64String(clientCertificatePkcs12.Replace("\r", "").Replace("\n", "")));
            X509CertificateCollection clientCertificateCollection = new X509CertificateCollection(new X509Certificate2[] { clientCertificate });
            SslStream stream = new SslStream(client.GetStream());
            stream.AuthenticateAsClient(host, clientCertificateCollection, SslProtocols.None, true);

            if (stream.IsMutuallyAuthenticated)
            {
                Console.WriteLine("Both client and server are authenticated");
            }
            else
            {
                Console.WriteLine("Not mutually authenticated");
            }
        }


        private static string clientCertificatePkcs12 = @"
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
";

    }
}
