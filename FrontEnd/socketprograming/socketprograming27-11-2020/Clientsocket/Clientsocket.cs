using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Clientsocket
{
    class Clientsocket
    {
        public static void clientsockets()
        {
            try
            {
                TcpClient tcpClient = new TcpClient();


                Console.WriteLine("connecting to server ");
                tcpClient.Connect("127.0.0.1", 4445);
                Console.WriteLine("Connected");
                Console.Write("Enter the string: ");
                String data = Console.ReadLine();
                NetworkStream networkStream = tcpClient.GetStream();

                byte[] bytesdata = Encoding.ASCII.GetBytes(data);
                int datalength = (int)bytesdata.Length;
                networkStream.Write(bytesdata, 0, datalength);
                networkStream.Flush();

                byte[] inStream = new byte[10025];
                int reclength = (int)inStream.Length;
                networkStream.Read(inStream, 0, reclength);
                string returndata = Encoding.ASCII.GetString(inStream);
                Console.WriteLine("data from server " + returndata);

                tcpClient.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }

           
        }
    }
}
