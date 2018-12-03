using System;
using System.Windows.Forms;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var viewModel = new ClientViewModel();
            var gui = new ClientGUI(viewModel);
            gui.PromptForName();
            var client = new ChatController(gui, viewModel);
            Application.Run(gui);
        }
    }
}
