﻿using System;
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

        private Principal formPrincipal;

        public MiniaturaDiagrama(Principal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
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
            if (!formPrincipal.TabControl.TabPages.Contains(this.Tab))
            {
                formPrincipal.TabControl.Controls.Add(this.Tab);
            }

            //seleciona a tab
            formPrincipal.TabControl.SelectedTab = Tab;
        }

    }
}
