using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.Logger;

namespace Lab3.Logger
{
    public abstract class SocketLogger : ILogger
    {
        protected ClientSocket clientSocket;

        public SocketLogger()
        {

        }

        public SocketLogger(string host, int port)
        {

        }

        ~SocketLogger() { }

        public abstract void Dispose();

        public void Log(params string[] messages)
        {
            string host = "google.com";
            int port = 80;

            using (ClientSocket clientSocket = new ClientSocket(host, port))
            {
                // request:

                foreach (var a in messages)
                {
                    string requestText = a;
                    byte[] requestBytes = Encoding.UTF8.GetBytes(requestText);

                    clientSocket.Send(requestBytes);
                }


                // response:

                byte[] responseBuffer = new byte[1024];
                int responseSize = clientSocket.Receive(responseBuffer);

                string responseText = Encoding.UTF8.GetString(responseBuffer, 0, responseSize); // received message

                // ...

                // cleaning:

                clientSocket.Close();
            }
        }
    }
}
