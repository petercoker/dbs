﻿using System;
using System.Windows.Forms;

namespace dbs.ObjectOrientatedProgramming.GUI.CarAge
{
    class Program
    {
        //The main entry point for the application.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CarAge());
        }
    }
}