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
            //send the new client/server a listing of all current ChatRooms
            foreach (var c in ChatRooms)
            {
                Send(c.ToString());
            }
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
            string header = e.Data.Substring(0, 4);
            string payload = e.Data.Substring(4);

            if (header == "JOIN")
            {
                char[] delim = { ',' };
                string[] messages = payload.Split(delim);
                for (int i = 0; i < messages.Length; i += 3)
                {
                    string name = messages[i];
                    string port = messages[i + 1];
                    string ipAddress = messages[i + 2];
                    ChatRooms.Add(new ChatRoom(name, port, ipAddress));
                    Console.WriteLine("New chat room joined! Name = {0}, Port = {1}", name, port);
                }
            }
            if (header == "QUIT")
            {
                //TODO: remove a server from the directory whenever it quits
            }
        }
    }
}
