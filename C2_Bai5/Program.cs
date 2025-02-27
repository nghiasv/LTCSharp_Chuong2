using C2_Bai5;
class Program
{
    static void Main()
    {
        Point p1232 = new Point(10, 20, PointColor.LightBlue);
        Point p2232 = new Point(30, 40, PointColor.BloodRed);
        Point p3232 = new Point(50, 60, PointColor.Gold);

        p1232.Display();
        p2232.Display();
        p3232.Display();

        Rectangle rect = new Rectangle(p1232, p3232);

        rect.Display();

        Console.ReadLine();
    }
}
