using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace drow
{
    abstract public class AbstrFigure
    {
        protected Color Color;

        protected static object o = new object();
        abstract public void drow(Graphics g);

        abstract public Point getCenter();
        abstract public void clear(Graphics g, Color color);
        abstract public bool selected(int x, int y);

        abstract public void changePosition(int x, int y);

        public AbstrFigure(Color col)
        {
            Color = col;
            
        }
    }
}
