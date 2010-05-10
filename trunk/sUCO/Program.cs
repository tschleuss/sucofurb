using System;
using System.Windows.Forms;
using sUCO.core;
using sUCO.forms;

namespace sUCO
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Principal());
        }
    }
}
