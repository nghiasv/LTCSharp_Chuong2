using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Bai5
{
    class Rectangle
    {
        public Point UpperLeft { get; set; }
        public Point BottomRight { get; set; }
        public Rectangle(Point upperLeft, Point bottomRight)
        {
            UpperLeft = upperLeft;
            BottomRight = bottomRight;
        }
        public void Display()
        {
            Console.Write("Rectangle X: ");
            UpperLeft.Display();
            Console.Write("Rectangle Y: ");
            BottomRight.Display();
            Console.WriteLine();
        }
    }

}
