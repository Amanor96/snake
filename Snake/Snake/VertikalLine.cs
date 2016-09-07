using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertikalLine : Figure
    {

        public VertikalLine (int xLine, int yUp, int yDown, char Sym)
        {
            LinePoint = new List<Point>();

            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point(xLine,y,Sym);
                LinePoint.Add(p);
            }
        }
}
}
