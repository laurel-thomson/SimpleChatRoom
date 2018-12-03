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
            string name = uxNameTextBox.Text;
            if (name == "")
            {
                MessageBox.Show("You must enter a name!");
                return;
            }
            if (!IsValidName(name))
            {
                MessageBox.Show("Names cannot contain the character ':'.");
                return;
            }
            Name = name;
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool IsValidName(string name)
        {
            foreach(var c in name)
            {
                if (c == ':')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
