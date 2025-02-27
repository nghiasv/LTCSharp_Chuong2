internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập số lượng phần tử: ");
        int n232 = int.Parse(Console.ReadLine());
        int[] numbers = new int[n232];
        for (int i232 = 0; i232 < n232; i232++)
        {
            Console.Write($"Nhập phần tử thứ {i232 + 1}: ");
            numbers[i232] = int.Parse(Console.ReadLine());
        }
    }
}