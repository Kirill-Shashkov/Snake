using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class point
    {
        public int a;
        public int b;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(a, b);
            Console.Write(sym);

        }
    }
}
