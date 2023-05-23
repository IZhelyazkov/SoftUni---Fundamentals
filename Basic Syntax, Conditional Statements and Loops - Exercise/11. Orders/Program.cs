using System.Diagnostics;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double pricePerCoffee = 0;

            for (int i = 1; i <= N; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                pricePerCoffee = pricePerCapsule * days * capsuleCount;
                totalPrice += pricePerCoffee;
                Console.WriteLine($"The price for the coffee is: ${pricePerCoffee:f2}");

            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}