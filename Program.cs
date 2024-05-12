using System;
using Math;
using Standards;

namespace csharp.calculator;

class Program
{
    static void _Debug()
    {
        string operation = Std.GetOperationOption();
        Console.WriteLine($"You have chosen '{operation}' as your operation.");
        double[] numbers = Std.GetTwoNumbersList();
        Console.Write("You have entered two integers: ");
        foreach (int number in numbers)
        {
            Console.Write(number);
        }
        Console.WriteLine("\n");

        double result = Operation.Add(numbers[0], numbers[1]);
        Console.WriteLine($"OP: {operation}, NUMS: {numbers[0]},{numbers[1]}, RESULT: {result}");
    }
    static void Main(string[] args)
    {
        Program._Debug();
    }
}
