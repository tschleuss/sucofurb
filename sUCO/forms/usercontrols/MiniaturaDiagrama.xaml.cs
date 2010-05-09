using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sUCO.forms.usercontrols
{
    /// <summary>
    /// Interaction logic for MiniaturaDiagrama.xaml
    /// </summary>
    public partial class MiniaturaDiagrama : UserControl
    {
        public TabCasoUso Tab
        {
            set;
            get;
        }

        public MiniaturaDiagrama()
        {
            InitializeComponent();
        }

        public void SetImage( RenderTargetBitmap bitmap )
        {
            this.diagrama.Source = bitmap;
        }

        private void diagrama_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }


        private void diagrama_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void diagrama_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!Principal.tabControl.TabPages.Contains(this.Tab))
            {
                Principal.tabControl.Controls.Add(this.Tab);
            }

            //seleciona a tab
            Principal.tabControl.SelectedTab = Tab;
        }

    }
}
