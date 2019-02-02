using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drow
{
    class Rectangle : AbstrFigure
    {
        Point center;
        int width;
        int height;
        public Rectangle(int wdth, int hgth, int x, int y, Color col) : base(col)
        {
            center = new Point(x, y);
            width = wdth; 
            height = hgth;
        }

        public void drow(Graphics g, Color color)
        {
            using (Pen p = new Pen(color))
            {
                lock (o)
                {
                    g.DrawRectangle(p, center.X, center.Y, width, height);
                }
            }
        }

        public override void changePosition(int x, int y)
        {
            center.X = x;
            center.Y = y;
        }

        public override void clear(Graphics g, Color color)
        {
            drow(g, color);
        }

        public override void drow(Graphics g)
        {
            drow(g, Color);
        }

        public override bool selected(int x, int y)
        {
            return x >= center.X - width && x <= center.X + width && y >= center.Y - height && y <= center.Y + height;
        }

        public override Point getCenter()
        {
            return center;
        }
    }
}
