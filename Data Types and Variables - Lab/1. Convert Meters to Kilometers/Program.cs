namespace _1._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            float km = input / 1000f;
            Console.WriteLine($"{km:f2}");
        }
    }
}