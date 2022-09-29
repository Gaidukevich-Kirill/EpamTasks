using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatServer
{
    public class ServerObject
    {
        private static TcpListener _tcpListener; //Server for listening
        private List<ClientObject> _clients = new List<ClientObject>(); //List of all clients that connecting
        
        private const string AddressString = "127.0.0.1";
        private const int Port = 8888;

        public delegate void BroadcastNotify(string message, string id);

        public event BroadcastNotify MessageArrivals;

        public ServerObject()
        {
            MessageArrivals += (message, id) =>
            {
                var data = Encoding.Unicode.GetBytes(message);

                //Sending message to other users
                foreach (var client in _clients)
                {
                    if (client.Id != id)
                    {
                        client.Stream.Write(data, 0, data.Length);
                    }
                }
            };
        }

        public void AddConnection(ClientObject client)
        {
            _clients.Add(client);
        }

        public void RemoveConnection(string id)
        {
            var client = _clients.FirstOrDefault(c => c.Id == id);

            if (client != null)
                _clients.Remove(client);
        }

        public void Listen()
        {
            try
            {
                _tcpListener = new TcpListener(IPAddress.Parse(AddressString), Port);
                _tcpListener.Start();
                Console.WriteLine("Server is working");

                while (true)
                {
                    var tcpClient = _tcpListener.AcceptTcpClient();

                    var clientObject = new ClientObject(tcpClient, this);
                    var clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Disconnect();    
            } 
        }

        public void MessageHandler(string message, string id)
        {
            MessageArrivals?.Invoke(message, id);
        }

        public void Disconnect()
        {
            _tcpListener.Stop();

            foreach (var client in _clients)
            {
                client.Close();
            }

            Environment.Exit(0);
        }
    }
}
