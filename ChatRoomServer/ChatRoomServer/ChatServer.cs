using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatRoomServer
{
    /// <summary>
    /// References used:
    /// https://docs.microsoft.com/en-us/dotnet/framework/network-programming/asynchronous-server-socket-example
    /// </summary>
    public class StateObject
    {
        public Socket ClientSocket = null;
        public const int BufferSize = 1024;
        public byte[] Buffer = new byte[BufferSize];
        public StringBuilder ReceivedDataString = new StringBuilder();
    }

    public class ChatServer
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        public static void StartListening()
        {
            byte[] localhost = { 127, 0, 0, 1 };
            var ipAddress = new IPAddress(localhost);
            var endPoint = new IPEndPoint(ipAddress, 11000);
            var listener = new Socket(
                ipAddress.AddressFamily,
                SocketType.Stream,
                ProtocolType.Tcp);

            try
            {
                listener.Bind(endPoint);
                listener.Listen(100);

                while(true)
                {
                    allDone.Reset();
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);
                    allDone.WaitOne();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void AcceptCallback(IAsyncResult result)
        {
            allDone.Set();

            var listener = (Socket)result.AsyncState;
            var socket = listener.EndAccept(result);

            var state = new StateObject();
            state.ClientSocket = socket;
            socket.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult result)
        {
            var content = String.Empty;
            var state = (StateObject)result.AsyncState;
            var socket = state.ClientSocket;
            int bytesRead = socket.EndReceive(result);

            if (bytesRead > 0)
            {
                state.ReceivedDataString.Append(
                    Encoding.ASCII.GetString(
                        state.Buffer,
                        0,
                        bytesRead)
                    );
                content = state.ReceivedDataString.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the   
                    // client. Display it on the console.  
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);
                    // Echo the data back to the client.  
                    Send(socket, content);
                }
            }
        }
        private static void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
