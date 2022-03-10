using System;

namespace ConditionalsLoopMethodsDemo
{
    class MainClass
    {
       static void Main()
        {
            Console.Write("Enter an initial number");
            int startingNum = int.Parse(Console.ReadLine());

            Console.Write("Enter an target number");
            int targetNum = int.Parse(Console.ReadLine());

            Console.Write("Enter a range");
            int range = int.Parse(Console.ReadLine());

            string results = IsWithinRange(startingNum, targetNum, range) ? "It's within range." : "It's not within range.";

            Console.WriteLine($"Given a starting number of: {startingNum} and a target number: {targetNum}. {results}");
        }

        // access modifier - static (no not) - return type - name(parms in here)
        private static bool IsWithinRange(int starting, int target, int range)
        {
            // true or false?  if starting - target is greater than or equal the negative range AND starting - target is less than or equal to range
            return (starting - target) >= -range && (starting - target) <= range;
        }
    }
}
