using System;
using System.Collections.Generic;
using System.Text;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ChatRoomDirectory
{
    public class ChatSocketBehavior : WebSocketBehavior
    {
        public static List<ChatRoom> ChatRooms = new List<ChatRoom>();

        protected override void OnOpen()
        {
            //if a client is connecting to the directory, send it a list of all chat rooms

            //if a server is connecting to the directory, don't send it anything
        }

        protected override void OnClose(CloseEventArgs e)
        {
            //when a server closes, need to remove it from the directory
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            //should not be getting messages from a client (client will be given IPaddress & port number of 
            //each chat room and connect to the server on its own

            //if we get a message from a server, it could either be a join message or a quit message
        }
    }
}
