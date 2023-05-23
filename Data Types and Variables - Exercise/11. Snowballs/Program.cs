namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            double snowballValue = 0;
            double maxValue = double.MinValue;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            int maxSnowballSnow = 0;
            int maxBallTime = 0;
            int maxBallQuality = 0;

            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                 snowballSnow = int.Parse(Console.ReadLine());
                 snowballTime = int.Parse(Console.ReadLine());
                 snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = Math.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxBallTime = snowballTime;
                    maxBallQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{maxSnowballSnow} : {maxBallTime} = {maxValue} ({max})");
        }
    }
}