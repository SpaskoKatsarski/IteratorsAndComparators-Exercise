﻿using System;
using System.Linq;

namespace CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> sortFunct = (x, y) => (x % 2 == 0) && (y % 2 != 0) ? -1 : 
                                            x % 2 != 0 && y % 2 == 0 ? 1 : x < y ? - 1 : 0;

            Array.Sort(numbers, (x, y) => sortFunct(x, y));

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
