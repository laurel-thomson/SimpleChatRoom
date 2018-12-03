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
    public partial class JoinRoomPrompt : Form
    {
        private ClientViewModel _viewModel;

        public JoinRoomPrompt(ClientViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
            uxChatRoomBindingSource.DataSource = _viewModel.ChatRooms;
        }

        private void uxChatRoomsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _viewModel.ChosenChatRoom = _viewModel.ChatRooms.ElementAt(e.RowIndex);
            Close();
        }
    }
}
