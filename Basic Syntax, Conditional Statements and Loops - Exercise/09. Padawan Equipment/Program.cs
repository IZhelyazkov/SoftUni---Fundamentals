namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float amountOfMoney = float.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            double freeBelts = countOfStudents / 6;

            double neededSum = (countOfStudents + Math.Ceiling(countOfStudents * 0.1)) * priceOfLightsabers + countOfStudents * priceOfRobes + (countOfStudents - freeBelts) * priceOfBelts;
            if (amountOfMoney >= neededSum)
            {
                Console.WriteLine($"The money is enough - it would cost {neededSum:f2}lv.");
            }
            else 
            {
                Console.WriteLine($" John will need {Math.Abs(amountOfMoney - neededSum):f2}lv more.");
            }

           
        } 
    }
}