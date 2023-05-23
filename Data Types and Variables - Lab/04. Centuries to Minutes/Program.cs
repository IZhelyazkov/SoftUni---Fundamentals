namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hour = days * 24;
            int minutes = hour * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hour} hours = {minutes} minutes");
        }
    }
}