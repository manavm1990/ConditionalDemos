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

            Console.Write("What's the ink level?");
            int inkLevel = int.Parse(Console.ReadLine());

            PrintDoc(hasPower, hasPaper, inkLevel);
        }

        // access modifier - static (no not) - return type - name(parms in here)
        private static bool IsWithinRange(int starting, int target, int range)
        {
            // true or false?  if starting - target is greater than or equal the negative range AND starting - target is less than or equal to range
            return (starting - target) >= -range && (starting - target) <= range;
        }

        // TODO: Print a document if it hasPower, and hasPaper and the ink level >= 10
        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            Console.Write(hasPaper && hasPower && inkLevel >= 10 ? "Printing 🖨" : "Unable to print 🙅🏾‍♂️");
        }
    }
}
