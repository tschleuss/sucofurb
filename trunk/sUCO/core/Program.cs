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
            Application.EnableVisualStyles();
            Application.Run(new Principal());
            DBManager.testeConexao();
        }
    }
}
