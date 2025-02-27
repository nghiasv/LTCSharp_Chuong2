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
        Point p1232 = new Point(10, 20, PointColor.LightBlue);
        Point p2232 = new Point(30, 40, PointColor.BloodRed);
        Point p3232 = new Point(50, 60, PointColor.Gold);
        p1232.Display();
        p2232.Display();
        p3232.Display();

        Console.ReadLine();
    }
}