﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace sUCO.diagram
{
    public partial class DiagramaWPF : UserControl
    {
        public DiagramaWPF()
        {
            InitializeComponent();
        }


        public RenderTargetBitmap GetImageFromCanvas()
        {
            RenderTargetBitmap renderBitmap = null;
            Transform transform = this.MyDesigner.LayoutTransform;
            Size size = new Size(this.MyDesigner.ActualWidth, this.MyDesigner.ActualHeight);

            if (size.Height > 0 && size.Width > 0)
            {

                renderBitmap =
                  new RenderTargetBitmap(
                    (int)size.Width,
                    (int)size.Height,
                    120d,
                    96d,
                    PixelFormats.Pbgra32);

                renderBitmap.Render(this.MyDesigner);
            }

            return renderBitmap;
        }
    }
}
