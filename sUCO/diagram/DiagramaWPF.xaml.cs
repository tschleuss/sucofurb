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

            Transform transform = this.MyDesigner.LayoutTransform;

            this.MyDesigner.LayoutTransform = null;
            Size size = new Size(this.MyDesigner.ActualWidth, this.MyDesigner.ActualHeight);

            this.MyDesigner.Measure(size);
            this.MyDesigner.Arrange(new Rect(size));

            RenderTargetBitmap renderBitmap =
              new RenderTargetBitmap(
                (int)size.Width,
                (int)size.Height,
                96d,
                96d,
                PixelFormats.Pbgra32);

            renderBitmap.Render(this.MyDesigner);

            return renderBitmap;
        }
    }
}
