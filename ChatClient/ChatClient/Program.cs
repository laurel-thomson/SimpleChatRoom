using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var gui = new ClientGUI();
            var client = new ChatController(gui);
            gui.InitializeSendMessageDelegate(client.SendMessage);
            Application.Run(gui);
        }
    }
}
