using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatClient
{
    internal class Program
    {
        public const string Address = "127.0.0.1";
        public const int Port = 8888;

        static void Main(string[] args)
        {
            Console.Write("Input your name: ");
            var userName = Console.ReadLine();
            TcpClient client = null;

            try
            {
                client = new TcpClient(Address, Port);
                var stream = client.GetStream();

                while (true)
                {
                    Console.Write($"{userName}: ");
                    var message = Console.ReadLine();
                    message = String.Format($"{userName}: {message}");

                    if (message == null)
                    {
                        throw new ArgumentNullException();
                    }

                    byte[] data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    stream.Flush();

                    //Get answer
                    data = new byte[2];
                    var stringBuilder = new StringBuilder();
                    var bytes = 0;

                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        stringBuilder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    } while (stream.DataAvailable);

                    message = stringBuilder.ToString();
                    Console.WriteLine($"Server: {message}");
                }
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                if (client != null)
                    client.Close();
            }
        }
    }
}
