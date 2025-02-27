internal class Program
{
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
        public Point(int x, int y, PointColor color)
        {
            X232 = x;
            Y232 = y;
            Color232 = color;
        }
        public void Display()
        {
            Console.WriteLine($"Point({X232}, {Y232}) - Color: {Color232}");
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}