using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Linq;

namespace Client_gui
{
    class MySocket
    {
        static private IPEndPoint endPoint;
        static private Socket socket;
        static private NetworkStream networkStream;

        public MySocket(int port = 6969)
        {
            this.Start(port);
        }

        private void Start(int port = 6969)
        {
            endPoint = new IPEndPoint(IPAddress.Loopback, port);
            socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(endPoint);
            networkStream = new NetworkStream(socket, true);
        }
        public static byte[] SendRecieve(byte[] msg, byte code=0)
        {
            byte[] response = new byte[1024];
            byte[] lenBytes = new byte[4];
            int length = msg != null ? msg.Length : 0;
            byte[] msgCombined = new byte[5 + length];
            int bytesRead = 0;
            
            lenBytes = BitConverter.GetBytes(length);

            //adding the code and the length
            msgCombined[0] = (byte)code;
            for (int i = 0; i < 4; i++)
            {
                msgCombined[i + 1] = lenBytes[i]; 
            }
            for (int i = 0; i < length; i++)
            {
                msgCombined[i + 5] = msg[i];
            }


            networkStream.Write(msgCombined, 0, msgCombined.Length);

            bytesRead = networkStream.Read(response, 0, response.Length);

            return response;
        }
    }
}
