using System.Threading.Channels;

namespace P09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 2*i - 1;
                Console.WriteLine(2 * i - 1);

            }
            Console.WriteLine($"Sum: {sum}");
        } 
    }
}