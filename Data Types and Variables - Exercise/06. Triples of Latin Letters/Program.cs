namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = 97;
            int finish = 97 + n;

            for (int i = start; i < finish; i++)
            {
                for (int j = start; j < finish; j++)
                {
                    for (int k = start; k < finish; k++)
                    {
                        Console.Write($"{(char)i}{(char)j}{(char)k}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}