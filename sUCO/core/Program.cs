using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sUCO
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new formPrincipal());
        }
        
    }
}
