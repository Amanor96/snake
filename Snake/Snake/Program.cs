using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.SetWindowPosition(20,20);
            Console.SetWindowSize(80,25);
            Console.SetBufferSize(80,25);
            

            
            HorizontalLine LineUp = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine LineDown = new HorizontalLine(0,78,24,'+');
            VertikalLine LineLeft = new VertikalLine(79, 23, 0, '+');
            VertikalLine LineRight = new VertikalLine(0, 23, 0, '+');

            LineUp.Draw();
            LineDown.Draw();
            LineLeft.Draw();
            LineRight.Draw();

            Point p = new Point(10,10,'*');

            Snake snake = new Snake( p, 3, Direction.Right );
            snake.Draw();
            Console.ReadKey();



        }
    }
}
