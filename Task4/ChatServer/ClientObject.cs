using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    public class ClientObject
    {
        public readonly TcpClient Client;

        public ClientObject(TcpClient client)
        {
            Client = client;
        }

        public void Process()
        {
            NetworkStream stream = null;

            try
            {
                stream = Client.GetStream();
                var data = new byte[64];

                while (true)
                {
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

                    message = TranslitDictionary.ConvertToLatin(message.Substring(message.IndexOf(':') + 2));
                    data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (Client != null)
                    Client.Close();
            }
        }


    }
}
