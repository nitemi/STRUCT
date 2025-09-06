using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCT
{
    internal struct Struct
    {
        public int X;
        public int Y;

        public Struct(int x, int y)
        {
            X = x; Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"x: {X}, y: {Y}");
        }
    }
}
