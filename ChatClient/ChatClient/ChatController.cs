using System;
using WebSocketSharp;

namespace ChatClient
{
   public class ChatController
    {
        private WebSocket _socket;
        private ClientGUI _gui;

        public ChatController(ClientGUI gui)
        {
            //Creating a new WebSocket that will connect to the WebServerSocket at port #11000
            _socket = new WebSocket("ws://127.0.0.1:11000/chat");
            _socket.OnMessage += (sender, e) => { MessageReceived(e.Data); };
            _socket.Connect();
            _gui = gui;
        }

        public void MessageReceived(string message)
        {
            _gui.AddMessageToList(message);
        }

        public void SendMessage(string message)
        {
            _socket.Send(message);
        }
    }
}
