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

            // TODO: Write the result by calling IsWithinRange
            Console.WriteLine($"Given a starting number of: {startingNum} and a target number: {targetNum}. It's {IsWithinRange(startingNum, targetNum, range)}");
        }

        // access modifier - static (no not) - return type - name(parms in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            return (num - target) <= range;
        }
    }
}
