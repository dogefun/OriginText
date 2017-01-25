using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

//final ver.
//16.12.22
//ArcherG

namespace OriginText
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
            Application.Run(new form());
        }
    }
}
