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

        public void Draw()
        {
            // выводит символ на экран по заданным координатам.

            Console.SetCursorPosition(x, y);
            Console.Write(Sym);
        }
    }
}
