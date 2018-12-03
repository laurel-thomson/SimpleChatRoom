using System;
using System.ComponentModel;

namespace ChatClient
{
    public class ClientViewModel
    {
        public BindingList<Message> Messages { get; }

        public string UserName { get; set; }

        public ClientViewModel()
        {
            Messages = new BindingList<Message>();
        }
    }
}
