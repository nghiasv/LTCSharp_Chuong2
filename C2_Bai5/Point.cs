using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Bai5
{
    using System;
    enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }
    class Point
    {
        public int X232 { get; set; }
        public int Y232 { get; set; }
        public PointColor Color232 { get; set; }
        public Point(int x232, int y232, PointColor color232)
        {
            X232 = x232;
            Y232 = y232;
            Color232 = color232;
        }
        public void Display()
        {
            Console.WriteLine($"Point({X232}, {Y232}) - Color: {Color232}");
        }
    }

}
