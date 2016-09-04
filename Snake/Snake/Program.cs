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
            Point p1 = new Point(1,4,'#');
            p1.Draw();

            Point p2 = new Point(5, 8, '&');
            p2.Draw();

            Console.ReadKey();



            List<char> sym = new List<char>();
            sym.Add( '@' );
            sym.Add('#');
            sym.Add('%');
            sym.Add('*');

            foreach(char n in sym)
            {
                Console.Write(n);
            }
            Console.ReadKey();


            List<Point> POINT = new List<Point>();
            POINT.Add( p1 );
            POINT.Add( p2 );


            Console.SetCursorPosition(0, 0);
            Console.Write(POINT);
            Console.ReadKey();
        }

        
        


    }
}
