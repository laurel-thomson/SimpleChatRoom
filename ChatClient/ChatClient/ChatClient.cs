using System;
using WebSocketSharp;

namespace ChatClient
{
   public class ChatClient
    {
        private WebSocket _socket;

        public ChatClient()
        {
            //Creating a new WebSocket that will connect to the WebServerSocket at port #11000
            _socket = new WebSocket("ws://127.0.0.1:11000/chat");
            _socket.OnMessage += (sender, e) => { MessageReceived(e.Data); };
            _socket.Connect();
        }

        public void MessageReceived(string message)
        {
            //do something with the received message
        }
    }
}
