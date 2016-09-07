﻿using System;
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
        public Snake (Point tail, int lenght, Direction direction)
        {
            LinePoint = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point( tail );
                p.Move(i,direction);
                LinePoint.Add(p);
            }
        }
    }
}
