﻿using System;
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
            var client = new ChatClient();
            Application.Run(new ClientGUI());
        }
    }
}
