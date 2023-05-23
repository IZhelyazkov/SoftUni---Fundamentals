using System.Globalization;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int obshto = 0;
            int takova = 0;
            bool toe = false;
            for (int ch = 1; ch <= kolkko; ch++)
            {
                takova = ch;
                while (ch > 0)
                {
                    sumOfDigits += Digits % 10;
                    digits = digits / 10;
                }
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine("{0} -> {1}", takova, toe);
                obshto = 0;
                ch = takova;
            }
        }
    }
}