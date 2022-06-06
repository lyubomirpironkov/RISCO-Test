using System;

namespace RISCOHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var arr = new int[] { -2, 2, 3, 1, 3, 4, 3, 4, 6, 4, 5 };
            var sum = 8;
            Console.WriteLine($"Does the array has two integers with sum {sum}? {Helper.ArrayHasSum(arr, sum)}");
        }
    }
}
