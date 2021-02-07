//Program.cs
//Created: 2020-10-22 by Andrius Sukys
//Updated: 2020-10-30 by Andrius Sukys


using System;
using System.Windows.Forms;

namespace CookBook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
