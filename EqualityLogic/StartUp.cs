using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                sortedSet.Add(new Person(input[0], int.Parse(input[1])));
                hashSet.Add(new Person(input[0], int.Parse(input[1])));
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
