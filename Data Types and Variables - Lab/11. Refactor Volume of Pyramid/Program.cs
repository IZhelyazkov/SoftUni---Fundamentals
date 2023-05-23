namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double volumeOfPyramid = (length * width *heigth) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volumeOfPyramid:f2}");
        }
    }
}