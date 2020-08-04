using System;
using System.Net.Security;
using System.Net.Sockets;

namespace IsMutuallyAuthenticatedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "www.microsoft.com";
            TcpClient client = new TcpClient(host, 443);
            SslStream stream = new SslStream(client.GetStream());
            stream.AuthenticateAsClient(host);
            if (stream.IsMutuallyAuthenticated)
            {
                Console.WriteLine("Both client and server are authenticated");
            }
            else
            {
                Console.WriteLine("Not mutually authenticated");
            }
        }
    }
}
