﻿using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    public class ClientObject
    {
        public string Id { get; private set; }

        public NetworkStream Stream { get; private set; }

        public List<string> UserMessages = new List<string>();

        public readonly TcpClient Client;

        public readonly ServerObject Server;

        public string UserName { get; private set; }

        public ClientObject(TcpClient client, ServerObject server)
        {
            Id = Guid.NewGuid().ToString();
            Client = client;
            Server = server;
            server.AddConnection(this);
        }

        public void Process()
        {
            try
            {
                Stream = Client.GetStream();
                var message = GetMessage();
                UserName = message;
                message = UserName + " joined in the chat";
                Console.WriteLine(message);

                while (true)
                {
                    try
                    {
                        message = GetMessage();
                        message = TranslitDictionary.ConvertToLatin(message);
                        UserMessages.Add(message);
                        message = String.Format($"{UserName}: {message}");
                        Console.WriteLine(message);
                        Server.MessageHandler(message, Id);
                    }
                    catch
                    {
                        message = String.Format($"{UserName} left the chat");
                        Console.WriteLine(message);
                        Server.MessageHandler(message, Id);
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Server.RemoveConnection(this.Id);
                Close();
            }
        }

        private string GetMessage()
        {
            var stringBuilder = new StringBuilder();
            var data = new byte[64];
            var bytes = 0;

            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                stringBuilder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

            return stringBuilder.ToString();
        }

        public void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (Client != null)
                Client.Close();
        }
    }
}
