using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatServer
{
    internal class Program
    {
        static ServerObject server;
        static Thread listenThread;

        static void Main(string[] args)
        {
            try
            {
                server = new ServerObject();
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start();

            }
            catch (Exception exception)
            {
                server.Disconnect();
                Console.WriteLine(exception.Message);
            }
        }
    }
}
