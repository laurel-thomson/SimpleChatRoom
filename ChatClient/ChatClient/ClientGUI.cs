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
        private string _name;

        public ClientGUI()
        {
            _messages = new List<string>();
            InitializeComponent();
        }

        public void LaunchNamePrompt()
        {
            using (var form = new NamePrompt())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _name = form.Name;
                    _sendMessage(":" + _name);
                }
            }

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
                uxDisplayMessagesTextBox.Text += message + "\r\n";
            }));
        }

        private void uxSendMessageButton_Click(object sender, EventArgs e)
        {
            _sendMessage(_name + ": " + uxMessageTextBox.Text);
            uxMessageTextBox.Text = "";
        }
    }
}
