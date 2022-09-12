using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatClient
{
    internal class Program
    {
        private static string _userName;
        public const string Address = "127.0.0.1";
        public const int Port = 8888;

        static void Main(string[] args)
        {
            Console.Write("Input your name: ");
            _userName = Console.ReadLine();
            TcpClient client = null;

            try
            {
                client = new TcpClient(Address, Port);
                var stream = client.GetStream();

                while (true)
                {
                    Console.Write($"{_userName}: ");
                    var message = Console.ReadLine();

                    if (message == null)
                    {
                        throw new ArgumentNullException();
                    }

                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }

            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
