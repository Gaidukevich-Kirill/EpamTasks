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
        public const string Address = "127.0.0.1";
        public const int Port = 8888;
        static TcpClient client;
        static NetworkStream stream;

        static void Main(string[] args)
        {
            Console.Write("Write your name: ");
            userName = Console.ReadLine();
            client = new TcpClient();

            try
            {
                client.Connect(Address, Port);
                stream = client.GetStream();

                var message = userName;
                var data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);

                //Creating new thread for getting data
                var receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start();

                Console.WriteLine($"Welcome, {userName}");
                SendMessage();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        static void SendMessage()
        {
            while (true)
            {
                Console.Write("Write cyrillic message: ");
                var message = Console.ReadLine();
                var data = Encoding.Unicode.GetBytes(message);

                stream.Write(data, 0, data.Length);
            }
        }

        static void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    var data = new byte[64];
                    var stringBuilder = new StringBuilder();
                    var bytes = 0;

                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        stringBuilder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    } 
                    while (stream.DataAvailable);

                    var message = stringBuilder.ToString();
                    Console.WriteLine(message);
                }
                catch (Exception exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Connection is interrupted");
                    Console.ReadLine();
                    Console.WriteLine(exception.Message);
                }
            }
        }

        static void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
            Environment.Exit(0);
        }
    }
}
