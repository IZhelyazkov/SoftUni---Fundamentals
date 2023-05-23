namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spice = 0;
            int yield = 0;
            int days = 0;

            while (startingYield >= 100)
            {
                days++;
                spice += startingYield;
                spice -= 26;
                startingYield -= 10;
            }
            spice -= 26;
            if (spice < 0)
            {
                spice = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(spice);
        }
    }
}