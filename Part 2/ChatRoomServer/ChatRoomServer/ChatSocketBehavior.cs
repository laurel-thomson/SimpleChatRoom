using System;
using System.Collections.Generic;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ChatRoomServer
{
    public class ChatSocketBehavior : WebSocketBehavior
    {
        public static List<string> Messages = new List<string>();
        public static List<string> UserNames = new List<string>();

        protected override void OnOpen()
        {
            //When a new client connects to the server, send it all of the stored
            //messages
            foreach (var m in Messages)
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
                if (UserNames.Count == 0)
                {
                    Send("You are the first to join the chat!");
                }
                else if (UserNames.Contains(name))
                {
                    //When received from the server, a colon means that the
                    //user name is already taken (names can't contain colons and user
                    //messages are always prefaced by names)
                    Send(":");
                }
                else
                {
                    Sessions.Broadcast(name + " has joined the chat.");
                }
                UserNames.Add(name);
            }
            else
            {
                //The message is a general chat message that needs to be broadcasted to
                //all the clients.
                Sessions.Broadcast(e.Data);
                Messages.Add(e.Data);
            }
        }
    }
}
