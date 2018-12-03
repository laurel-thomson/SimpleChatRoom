using System;
using System.ComponentModel;

namespace ChatClient
{
    public class ClientViewModel
    {
        public BindingList<ChatRoom> ChatRooms { get; }

        public ChatRoom ChosenChatRoom { get; set; }

        public BindingList<Message> Messages { get; }

        public string UserName { get; set; }

        public ClientViewModel()
        {
            Messages = new BindingList<Message>();
            ChatRooms = new BindingList<ChatRoom>();
        }
    }
}
