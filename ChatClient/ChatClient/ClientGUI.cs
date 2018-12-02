using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class ClientGUI : Form
    {
        private Action<String> _sendMessage;
        private List<String> _messages;

        public ClientGUI()
        {
            _messages = new List<string>();
            InitializeComponent();
        }

        public void InitializeSendMessageDelegate(Action<String> SendMessage)
        {
            _sendMessage = SendMessage;
        }

        public void AddMessageToList(string message)
        {
            Invoke(new Action(() =>
            {
                _messages.Add(message);
                uxMessageListView.Items.Add(message);
            }
                ));
        }

        private void uxSendMessageButton_Click(object sender, EventArgs e)
        {
            _sendMessage(uxMessageTextBox.Text);
        }
    }
}
