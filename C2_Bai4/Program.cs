using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử: ");
        int n232 = int.Parse(Console.ReadLine());
        int[] ds232 = new int[n232];
        for (int i232 = 0; i232 < n232; i232++)
        {
            Console.Write($"Nhập phần tử thứ {i232 + 1}: ");
            ds232[i232] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Các số chẵn trong mảng là:");
        foreach (int num232 in ds232) 
        {
            if (num232 % 2 == 0)
            {
                Console.Write(num232 + " ");
            }
        }
        Console.WriteLine("\nTạm Biệt!");
    }
}