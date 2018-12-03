using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ChatRoomServer
{
    public class ServerController
    {
        public WebSocketServer Server { get; private set; }

        private IList<ChatRoom> _allChatRooms = new List<ChatRoom>();
        private ChatRoom _chatRoom;
        private WebSocket _socket;

        public ServerController()
        {
            //Creating a new WebSocket that will connect to the ChatRoomDirectory at port #11000
            _socket = new WebSocket("ws://127.0.0.1:11000/dir");
            _socket.OnMessage += (sender, e) => { MessageReceived(e.Data); };
            _socket.Connect();
        }

        //All messages will be from the chat room directory, and will only be a listing of all chat rooms
        private void MessageReceived(string data)
        {
            char[] delim = { ',' };
            string[] messages = data.Split(delim);
            for (int i = 0; i < messages.Length; i += 3)
            {
                string name = messages[i];
                string port = messages[i + 1];
                string ipAddress = messages[i + 2];
                _allChatRooms.Add(new ChatRoom(name, port, ipAddress));
            }
            PromptUserForChatName();
        }

        private void PromptUserForChatName()
        {
            string name = "";
            string port = "";

            bool validName = false;
            while (!validName)
            {
                Console.WriteLine("Please enter the name of your chat room: ");
                name = Console.ReadLine();
                if (_allChatRooms.Any(c => c.Name == name))
                {
                    Console.WriteLine("That name is already taken!");
                }
                else validName = true;
            }

            Console.WriteLine("The server will be started on localhost.");

            bool validPort = false;
            while (!validPort)
            {
                Console.WriteLine("Please enter the port number you would like to use: ");
                port = Console.ReadLine();
                if (_allChatRooms.Any(c => c.Port == port))
                {
                    Console.WriteLine("That port is already taken!");
                }
                else if (!port.All(Char.IsDigit))
                {
                    Console.WriteLine("The port needs to be an integer.");
                }
                else if (Convert.ToInt32(port) < 1)
                {
                    Console.WriteLine("The port needs to be a positive number.");
                }
                else validPort = true;
            }
            _chatRoom = new ChatRoom(name, port, "127.0.0.1");

            //send message to the ChatDirectory with the chosen name, port, and ipaddress
            _socket.Send("JOIN," + _chatRoom.ToString());

            SetUpChatRoom();
        }

        private void SetUpChatRoom()
        {
            //start at new Web Socket Server at the port number specified by the user
            Server = new WebSocketServer(Convert.ToInt32(_chatRoom.Port));

            Server.AddWebSocketService<ChatSocketBehavior>("/chat");

            Server.Start();
        }
    }
}
