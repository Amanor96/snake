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
            /*Point p1 = new Point(1,4,'#');
            p1.Draw();

            Point p2 = new Point(5, 8, '&');
            p2.Draw();

            Point p3 = new Point(2, 7, '*');
            p3.Draw();

            Point p4 = new Point(9, 2, '^');
            p4.Draw();*/

            VertikalLine LineV = new VertikalLine(5,7,12,'|');
            LineV.Draw();

            HorizontalLine LineH = new HorizontalLine(10,20,15,'*');
            LineH.Draw();
            Console.ReadKey();
             
        }

        
        


    }
}
