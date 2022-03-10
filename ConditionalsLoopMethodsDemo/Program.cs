using System;

namespace ConditionalsLoopMethodsDemo
{
    class MainClass
    {
       static void Main()
        {
            Console.Write("Do we have power 🔌? (y/n)");
            bool hasPower = Console.ReadLine().ToLower() == "y";

            Console.Write("Do we have paper? (y/n");
            bool hasPaper = Console.ReadLine().ToLower() == "y";

            int inkLevel = PromptUser4Int("What's the ink level?");

            string name = PromptUser("What is your name?");

            PrintDoc(hasPower, hasPaper, inkLevel);
        }

        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            Console.Write(hasPaper && hasPower && inkLevel >= 10 ? "Printing 🖨" : "Unable to print 🙅🏾‍♂️");
        }

        private static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private static int PromptUser4Int(string message)
        {
            int result;
            while(!int.TryParse(PromptUser(message), out result))
            {
                PromptUser("Invalid Input! Press any key to continue");
            }

            return result;
        }
    }
}
