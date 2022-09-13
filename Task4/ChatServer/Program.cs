using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatServer
{
    internal class Program
    {
        public const string AddressString = "127.0.0.1";
        public const int Port = 8888;
        static TcpListener listener;

        static void Main(string[] args)
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse(AddressString), Port);
                listener.Start();
                Console.WriteLine("Server is working");

                while (true)
                {
                    var client = listener.AcceptTcpClient();
                    var clientObject = new ClientObject(client);

                    //Creating new tread for service new client
                    var clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                if (listener != null)
                {
                    listener.Stop();
                }
            }
        }
    }
}
