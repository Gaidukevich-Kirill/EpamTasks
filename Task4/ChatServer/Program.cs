using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatServer
{
    internal class Program
    {
        private const int port = 8888;
        private const string address = "127.0.0.1";
        
        static void Main(string[] args)
        {
            //Console.WriteLine(TranslitDictionary.ConvertToLatin("Проверяю чтоб работало"));

            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(address), port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Bind(ipEndPoint);
            socket.Listen(5);

            try
            {

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            socket.Close();
        }
    }
}
