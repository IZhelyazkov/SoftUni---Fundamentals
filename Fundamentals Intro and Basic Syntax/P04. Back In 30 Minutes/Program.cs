namespace P04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if ( minutes <= 59)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            else if (minutes > 59)
            {
                minutes -= 60;
                hours++;
                if (hours > 23)
                {
                    hours = 0;

                    Console.WriteLine($"{hours}:{minutes:d2}");
                }
                else
                {
                    Console.WriteLine($"{hours}:{minutes:d2}");
                }
            }
        }
    }
}