using System;
using System.Collections.Generic;
using System.Linq;
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
            //Whenever a new ChatServer or ChatClient connects to the Directory, send it a listing of
            //all available ChatRooms and their IP Address/Port #s.  If there are none, send the empty string.
            StringBuilder sb = new StringBuilder();
            foreach (var c in ChatRooms)
            {
                sb.Append(c.ToString());
            }
            Send(sb.ToString());
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
                string[] messages = payload.Split(delim,StringSplitOptions.RemoveEmptyEntries);
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
                ChatRooms.RemoveAll(x => x.Name == payload);
            }
        }
    }
}
