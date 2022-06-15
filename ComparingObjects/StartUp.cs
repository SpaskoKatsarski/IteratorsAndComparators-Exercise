using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] personInfo = command.Split();

                people.Add(new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]));
            }

            int index = int.Parse(Console.ReadLine()) - 1;

            int equalPeople = 0;
            int differentPeople = 0;

            foreach (var person in people)
            {
                if (people[index].CompareTo(person) == 0)
                {
                    equalPeople++;
                }
                else
                {
                    differentPeople++;
                }
            }

            if (equalPeople <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople} {differentPeople} {people.Count}");
            }
        }
    }
}
