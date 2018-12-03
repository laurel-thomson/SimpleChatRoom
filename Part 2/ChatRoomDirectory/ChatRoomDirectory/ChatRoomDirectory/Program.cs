using System;
using WebSocketSharp.Server;

namespace ChatRoomDirectory
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

            wss.Stop();
        }
    }
}
