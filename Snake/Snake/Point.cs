using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int x = 0;
        private int y = 0;
        private char Sym = ' ';

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            Sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            Sym = p.Sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Right)
                x = x + offset;
            if (direction == Direction.Left)
                x = x - offset;
            if (direction == Direction.Down)
                y = y + offset;
            if (direction == Direction.Up)
                y = y - offset;
        }

        internal void Clear()
        {
            Sym = ' ';
            Draw();
        }

        public void Draw()
        {
            // выводит символ на экран по заданным координатам.

            Console.SetCursorPosition(x, y);
            Console.Write(Sym);
        }
    }
}
