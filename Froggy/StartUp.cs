using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Lake<int> lake = new Lake<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
