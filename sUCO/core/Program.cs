using System;
using System.Windows.Forms;
using sUCO.core;

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
        }
    }
}
