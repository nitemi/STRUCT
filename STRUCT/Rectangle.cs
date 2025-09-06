using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCT
{
    internal class Rectangle
    {
        //Create a Rectangle struct with Width and Height and a method GetArea().
        public int Width;
        public int Height;
        //public Rectangle(int width, int height)
        //{
        //    Width = width; Height = height;
        //}
        public void  GetArea()
        {
            Console.WriteLine( Width * Height);
        }
        public int GetAreas()
        {
            int area = Width * Height;
            return area;
        }

    }
}
