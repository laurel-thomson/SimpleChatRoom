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
            //A colon before a name is used to denote a message that contains only
            //a new user's name
            if(e.Data[0] == ':')
            {
                string name = e.Data.Substring(1);
                Sessions.Broadcast(name + " has joined the chat.");
            }
            else
            {
                //The message is a general chat message that needs to be broadcasted to
                //all the clients.
                Sessions.Broadcast(e.Data);
            }
        }
    }
}
