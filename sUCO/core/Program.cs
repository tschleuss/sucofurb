using System;
using System.Windows.Forms;

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
