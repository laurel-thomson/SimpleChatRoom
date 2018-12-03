using System;
using WebSocketSharp.Server;

namespace ChatRoomServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new ServerController();

            //keep console open
            Console.ReadLine();

            handler.Server.Stop();
        }
    }
}
