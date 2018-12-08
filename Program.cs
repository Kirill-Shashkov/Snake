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
            point p1 = new point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = "*";
            p1.Draw();


            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
            Console.ReadLine();
        }
        static void Draw(int a, int b, char sym) {
            Console.SetCursorPosition(a, b);
            Console.Write(sym);
        }
    }
}
