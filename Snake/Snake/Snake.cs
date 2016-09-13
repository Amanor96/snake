using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        // tail - хвост
        // direction - направление
        Direction direction;
        public Snake (Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            LinePoint = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point( tail );
                p.Move(i,_direction);
                LinePoint.Add(p);
            }
        }

        internal void move()
        {
            Point tail = LinePoint.First();
            LinePoint.Remove(tail);
            tail.Clear();
            Point hend = GetNextPoint();
            LinePoint.Add( hend );
        }

        private Point GetNextPoint()
        {
            Point hend = LinePoint.Last();
            Point NewHend = new Point( hend );
            NewHend.Move(1, direction);

            return NewHend;
        }
    }
}
