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
            DBManager.testeConexao();
            Application.EnableVisualStyles();
            Application.Run(new Principal());
            //Application.Run(new Window1());
        }
    }
}
