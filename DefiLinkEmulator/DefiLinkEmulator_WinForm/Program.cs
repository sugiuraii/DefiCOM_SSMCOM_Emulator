﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DefiLinkEmulator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DefilinkEmulator_WinForm());
        }
    }
}
