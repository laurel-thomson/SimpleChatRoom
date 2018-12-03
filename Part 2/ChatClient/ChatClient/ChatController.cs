using System;
using System.Windows.Forms;
using WebSocketSharp;

namespace ChatClient
{
   public class ChatController
    {
        private WebSocket _directorySocket;
        private WebSocket _serverSocket;
        private ClientGUI _gui;
        private ClientViewModel _viewModel;

        public ChatController(ClientGUI gui, ClientViewModel viewModel)
        {
            _gui = gui;
            _viewModel = viewModel;

            //Creating a new WebSocket that will connect to the ChatDirectory at port #11000
            _directorySocket = new WebSocket("ws://127.0.0.1:11000/dir");
            _directorySocket.OnMessage += (sender, e) => { DirectoryMessageReceived(e.Data); };
            _directorySocket.Connect();
            while (true)
            {
                //wait for the directory to connect
            }
        }

        public void DirectoryMessageReceived(string message)
        {
            //the directory will send us a listing of all the chat rooms (the empty string means no chat rooms available)
            if (message != "")
            {
                char[] delim = { ',' };
                string[] messages = message.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < messages.Length; i += 3)
                {
                    string name = messages[i];
                    string port = messages[i + 1];
                    string ipAddress = messages[i + 2];
                    _viewModel.ChatRooms.Add(new ChatRoom(name, port, ipAddress));
                }
                _gui.PromptToJoinRoom();
                ConnectToChatRoom();
            }
            //if there are no chat rooms to connect to, not much for the chat client to do
            else
            {
                MessageBox.Show("There are no chat servers to connect.  Try again later!");
                Environment.Exit(0);
            }
        }

        private void ConnectToChatRoom()
        {
            //close the connection to the Directory
            _directorySocket.Close();

            //Creating a new WebSocket that will connect to the chosen chat server
            _serverSocket = new WebSocket("ws://" +
                _viewModel.ChosenChatRoom.IPAddress + ":" +
                _viewModel.ChosenChatRoom.Port + "/chat");
            _serverSocket.OnMessage += (sender, e) => { ServerMessageReceived(e.Data); };
            _serverSocket.Connect();
            _gui.InitializeSendMessageDelegate(SendMessageToServer);
            _gui.PromptForName();
            _gui.ShowDialog();
        }

        private void ServerMessageReceived(string message)
        {
            if (message[0] == ':')
            {
                //this means that a chosen name was rejected as a duplicate
                _gui.RepromptForName();
                _serverSocket.Send(":" + _viewModel.UserName);
            }
            else
            {
                //otherwise, the message is a chat message to be displayed
                if (_gui.IsHandleCreated)
                {
                    _gui.Invoke(new Action(() =>
                    {
                        _viewModel.Messages.Add(new Message(message));
                    }));
                }
                else
                {
                    _viewModel.Messages.Add(new Message(message));
                }
            }
        }

        public void SendMessageToServer(string message)
        {
            _serverSocket.Send(message);
        }
    }
}
