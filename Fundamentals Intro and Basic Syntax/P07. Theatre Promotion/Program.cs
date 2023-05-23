namespace P07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfday = Console.ReadLine().
            int age = int.Parse(Console.ReadLine());

            if (typeOfday == "Weekday")
            {
                if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error!");
                }
                else if (age > 64 && age <= 122) 
                {
                    Console.WriteLine("12$");
                }
                else if (age <= 18)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("18$");
                }
            }
            if (typeOfday == "Weekend")
            {
                if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error!");
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("15$");
                }
                else if (age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("20");
                }
            }
            if (typeOfday == "Holiday")
            {
                if (age < 0 || age > 122)
                {
                    Console.WriteLine("Error!");
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("10$");
                }
                else if (age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else
                {
                    Console.WriteLine("12");
                }
            }
        }
    }
}