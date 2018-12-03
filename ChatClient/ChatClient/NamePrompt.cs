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
    public partial class NamePrompt : Form
    {
        public string Name { get; set; }

        public NamePrompt()
        {
            InitializeComponent();
        }

        private void uxOKButton_Click(object sender, EventArgs e)
        {
            if (uxNameTextBox.Text == "")
            {
                MessageBox.Show("You must enter a name!");
            }
            else
            {
                Name = uxNameTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
