using System;
using Library.Std;

namespace csharp.calculator;

class Program
{
    static void Main(string[] args)
    {
        string operation = Std.GetOperationOption();
        Console.WriteLine($"You have chosen '{operation}' as your operation.");
        List<int> numbers = Std.GetTwoNumbers();
        Console.Write("You have entered two integers: ");
        foreach (int number in numbers)
        {
            Console.Write(number);
        }
        Console.WriteLine("\n");
    }
}
