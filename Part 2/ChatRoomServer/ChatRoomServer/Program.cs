using System;
using WebSocketSharp.Server;

namespace ChatRoomServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //start at new Web Socket Server at port #11000
            var wss = new WebSocketServer(11000);

            wss.AddWebSocketService<ChatSocketBehavior>("/chat");

            wss.Start();

            //Keep the program running
            Console.ReadLine();

            //TODO: the ChatRoomServer will also need a socket to the connect to the ChatRoomDirectory
            //will need to add an event handler for OnClose to send a closing message to the server
            //to remove it from its chat room directory

            wss.Stop();
        }
    }
}
