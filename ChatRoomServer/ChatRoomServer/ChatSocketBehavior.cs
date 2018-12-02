using System;
using System.Collections.Generic;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ChatRoomServer
{
    public class ChatSocketBehavior : WebSocketBehavior
    {
        public static List<String> messages = new List<String>();

        protected override void OnOpen()
        {
            //When a new client connects to the server, send it all of the stored
            //messages
            foreach (var m in messages)
            {
                Sessions.SendTo(ID, m);
            }
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            //Whenever a new message is received by the server, broadcast
            //the message to all clients.
            Sessions.Broadcast(e.Data);
        }
    }
}
