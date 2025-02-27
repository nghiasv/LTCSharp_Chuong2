internal class Program
{
    static public void Sinhvien(string HoTen232,
                           string MSV232,
                           int Tuoi232,
     string Nganh232 = "Cong nghe thong tin")

    {
        Console.WriteLine("HoTen: {0}", HoTen232);
        Console.WriteLine("MSV: {0}", MSV232);
        Console.WriteLine("Tuoi: {0}", Tuoi232);
        Console.WriteLine("Nghanh: {0}", Nganh232);
    }
    enum Nghia
    {
        Tuoi232 = 21
    }
    private static void Main(string[] args)
    {

        Sinhvien("Doan Kim Nghia", "22115053122232", (int)Nghia.Tuoi232);

    }
}