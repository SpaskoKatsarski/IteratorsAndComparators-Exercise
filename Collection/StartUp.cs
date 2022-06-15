using System;
using System.Linq;

namespace Collection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listy = new ListyIterator<string>();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "Create")
                {
                    listy = new ListyIterator<string>(cmdArgs.Skip(1).ToArray());
                }
                else if (cmdArgs[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (cmdArgs[0] == "Print")
                {
                    listy.Print();
                }
                else if (cmdArgs[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (cmdArgs[0] == "PrintAll")
                {
                    listy.PrintAll();
                }
            }
        }
    }
}
