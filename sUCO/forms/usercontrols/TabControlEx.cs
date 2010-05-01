using System;
using System.Windows.Forms;
using System.Drawing;

namespace sUCO.forms.usercontrols
{
    public delegate bool PreRemoveTab(int indx);
    public class TabControlEx : TabControl
    {
        public TabControlEx()
            : base()
        {
            PreRemoveTabPage = null;
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        public PreRemoveTab PreRemoveTabPage;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            TabPage tab = this.TabPages[e.Index];
            string titel = tab.Text;
            Font f = this.Font;
            Brush b = new SolidBrush(Color.Black);
            Pen p = new Pen(b);

            if (e.Index != 0)
            {
                Rectangle r = e.Bounds;
                r = GetTabRect(e.Index);
                r.Offset(2, 2);
                r.Width = 5;
                r.Height = 5;

                e.Graphics.DrawLine(p, r.X, r.Y, r.X + r.Width, r.Y + r.Height);
                e.Graphics.DrawLine(p, r.X + r.Width, r.Y, r.X, r.Y + r.Height);
                e.Graphics.DrawString(titel, f, b, new PointF(r.X + 5, r.Y));
            }
            else
            {
                e.Graphics.DrawString(titel, f, b, new PointF(5, 2));
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            Point p = e.Location;
            for (int i = 1; i < TabCount; i++)
            {
                Rectangle r = GetTabRect(i);
                r.Offset(2, 2);
                r.Width = 5;
                r.Height = 5;
                if (r.Contains(p))
                {
                    CloseTab(i);
                }
            }
        }

        private void CloseTab(int i)
        {
            if (PreRemoveTabPage != null)
            {
                bool closeIt = PreRemoveTabPage(i);
                if (!closeIt)
                    return;
            }
            TabPages.Remove(TabPages[i]);
        }
    }
}
