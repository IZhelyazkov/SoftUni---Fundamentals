﻿namespace P11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            for (int i = times; i <=10; i++)
            {
                Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
            }
            if (times > 10)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
            }
        }
    }
}