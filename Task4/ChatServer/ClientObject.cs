using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    public class ClientObject
    {
        public TcpClient Client;

        public ClientObject(TcpClient client)
        {
            Client = client;
        }


    }
}
