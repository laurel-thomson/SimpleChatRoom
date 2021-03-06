﻿using System;
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
        private Action<string> _sendMessage;
        private ClientViewModel _viewModel;

        public ClientGUI(ClientViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
            uxMessagesListBox.DataSource = _viewModel.Messages;
        }

        public void PromptForName()
        {
            using (var form = new NamePrompt())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _viewModel.UserName = form.Name;
                    _sendMessage(":" + _viewModel.UserName);
                }
            }
        }

        public void PromptToJoinRoom()
        {
            new JoinRoomPrompt(_viewModel).ShowDialog();
        }

        public void RepromptForName()
        {
            MessageBox.Show("Sorry! That name is already taken");
            PromptForName();
        }

        public void InitializeSendMessageDelegate(Action<String> SendMessage)
        {
            _sendMessage = SendMessage;
        }

        private void uxSendMessageButton_Click(object sender, EventArgs e)
        {
            _sendMessage(_viewModel.UserName + ": " + uxMessageTextBox.Text);
            uxMessageTextBox.Text = "";
        }
    }
}
