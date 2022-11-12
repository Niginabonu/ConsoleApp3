namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            if (n % 400 == 0 || (n % 4 == 0 && n % 100 != 0))
                Console.WriteLine(" 12/09/" + n);
            else Console.WriteLine(" 13/09/" + n);
            Console.ReadKey();
        }
    }
}