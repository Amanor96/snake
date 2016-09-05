using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertikalLine
    {
        List<Point> LinePoint;

        public VertikalLine (int xLine, int yUp, int yDown, char Sym)
        {
            LinePoint = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(xLine,y,Sym);
                LinePoint.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point p in LinePoint)
            {
                p.Draw();
            }
        }
}
}
