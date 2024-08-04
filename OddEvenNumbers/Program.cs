internal class Program
{
    private static void Main(string[] args)
    {
        int[] Numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        PrintNumbers("Numbers", Numbers);
        PrintNumbers("Even Numbers", Numbers.Where(n => IsEven(n)));
        PrintNumbers("Odd Numbers", Numbers.Where((n) => IsOdd(n)));
    }

    static void PrintNumbers(string title, IEnumerable<int> Numbers)
    {
        Console.Write($" {title} : [");
        foreach (var n in Numbers)
        {
            Console.Write($" {n} ,");
        }
        Console.Write($"]");
        Console.WriteLine();

    }

    static bool IsEven(int n) => n % 2 == 0;


    static bool IsOdd(int n) => !IsEven(n);
}