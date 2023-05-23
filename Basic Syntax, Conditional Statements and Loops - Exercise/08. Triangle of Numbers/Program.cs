namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int n = 1;

            while (n <= input)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{n} ");
                }
                n++;
                Console.WriteLine();
            }
        }
    }
}