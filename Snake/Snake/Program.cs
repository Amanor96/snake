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
            int x = 5;
            int y = 10;
            string Symbol = "$";
            PrintSymbol( x, y, Symbol );
            Console.ReadKey();

        }
        static void PrintSymbol (int x, int y, string Znak)
        {
            Console.SetCursorPosition( x , y );
            Console.Write( Znak );
        }
    }
}
