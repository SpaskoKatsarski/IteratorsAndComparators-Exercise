using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "Push")
                {
                    stack.Push(cmdArgs.Skip(1).Select(e => e.Split(",").First()).ToArray());
                }
                else if (cmdArgs[0] == "Pop")
                {
                    stack.Pop();
                }
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
