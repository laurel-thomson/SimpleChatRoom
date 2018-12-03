using System;
using System.Windows.Forms;
using WebSocketSharp;

namespace ChatClient
{
   public class ChatController
    {
        private WebSocket _socket;
        private ClientGUI _gui;
        private ClientViewModel _viewModel;

        public ChatController(ClientGUI gui, ClientViewModel viewModel)
        {
            _gui = gui;
            _viewModel = viewModel;

            //Creating a new WebSocket that will connect to the WebServerSocket at port #11000
            _socket = new WebSocket("ws://127.0.0.1:11000/chat");
            _socket.OnMessage += (sender, e) => { MessageReceived(e.Data); };
            _socket.Connect();
            _socket.Send(":" + _viewModel.UserName);
            _gui.InitializeSendMessageDelegate(SendMessage);
        }

        public void MessageReceived(string message)
        {
            if (message[0] == ':')
            {
                //this means that a chosen name was rejected as a duplicate
                _gui.Invoke(new Action(() =>
                {
                    _gui.RepromptForName();
                }));
                _socket.Send(":" + _viewModel.UserName);
            }
            else
            {
                //otherwise, the message is a chat message to be displayed
                _gui.Invoke(new Action(() =>
                {
                    _viewModel.Messages.Add(new Message(message));
                }));
            }
        }

        public void SendMessage(string message)
        {
            _socket.Send(message);
        }
    }
}
