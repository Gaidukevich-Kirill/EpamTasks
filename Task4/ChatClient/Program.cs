using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatClient
{
    internal class Program
    {
        static string userName;
        private const string address = "127.0.0.1";
        private const int port = 8888;

        static void Main(string[] args)
        {
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(address), port);
            Socket socket = new Socket(
                AddressFamily.InterNetwork, 
                SocketType.Stream, 
                ProtocolType.Tcp);

            socket.Connect(ipEndPoint);
        }
    }
}
