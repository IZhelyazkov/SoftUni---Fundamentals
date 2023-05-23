namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            int input = num;
            int sumOfFactorials = 0;

            while (num > 0)
            {
                int number = num % 10;
                int factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                sumOfFactorials += factorial;
                num /= 10;
            }
            

            if (sumOfFactorials == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}