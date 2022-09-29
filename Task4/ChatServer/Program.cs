using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServerObject server = null;
            try
            {
                server = new ServerObject();
                var listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start();
            }
            catch (Exception exception)
            {
                server?.Disconnect();
                Console.WriteLine(exception.Message);
            }
        }
    }
}
