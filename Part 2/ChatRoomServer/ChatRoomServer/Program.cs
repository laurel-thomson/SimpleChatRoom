using System;
using WebSocketSharp.Server;

namespace ChatRoomServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new ServerController();

            while (true)
            {
                //busy wait to keep the program from exiting
            }

        }
    }
}
