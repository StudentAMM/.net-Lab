using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drow
{
    internal class Triangle : AbstrFigure
    {
        Point center;
        int edge;
        public Triangle(int edg, int x, int y, Color col) : base(col)
        {
            center = new Point(x, y);
            edge = edg;
        }

        public override void changePosition(int x, int y)
        {
            center.X = x;
            center.Y = y;
        }

        private void drow(Graphics g, Color color)
        {
            using (Pen p = new Pen(color))
            {
                float angle = 0;
                SolidBrush brs = new SolidBrush(Color.Green);
                PointF[] pp = new PointF[3];
                int x = center.X, y = center.Y;
                pp[0].X = x;
                pp[0].Y = y;
                pp[1].X = (float)(x + edge * Math.Cos(angle));
                pp[1].Y = (float)(y + edge * Math.Sin(angle));
                pp[2].X = (float)(x + edge * Math.Cos(angle + Math.PI / 3));
                pp[2].Y = (float)(y + edge * Math.Sin(angle + Math.PI / 3));
                lock (o)
                {
                    g.DrawPolygon(p, pp);
                }
            }
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
            return x >= center.X - edge && x <= center.X + edge && y >= center.Y - edge && y <= center.Y + edge;
        }

        public override Point getCenter()
        {
            return center;
        }
    }
}
