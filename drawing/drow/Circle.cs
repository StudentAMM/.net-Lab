using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace drow
{
    class Circle:AbstrFigure
    {
        Point center;
        int range;

        public Circle(int rad, int x, int y, Color col):base(col)
        {
            center = new Point(x, y);
            range = rad;
        }

        private void drow(Graphics g, Color color)
        {
            using (Pen p = new Pen(color))
            {
                g.DrawEllipse(p, new RectangleF(center.X - range, center.Y - range, range * 2, range * 2));
            }
        }

        public override void drow(Graphics g)
        {
            drow(g, Color);
        }

        public override void clear(Graphics g, Color color)
        {
            drow(g, color);
        }

        public override bool selected(int x, int y)
        {
            return x>= center.X-range && x<=center.X+range && y>=center.Y-range && y<=center.Y+range;
        }

        public override void changePosition(int x, int y)
        {
            center.X = x;
            center.Y = y;
        }
    }
}
