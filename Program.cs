using System;
using Math;
using Standards;

namespace csharp.calculator;

class Program
{
    static void _Debug()
    {
        string operation = Std.GetOperationOption();
        double[] numbers = Std.GetTwoNumbersList(operation);
        double result = 0;

        switch (operation)
        {
            case "+":
                result = Operation.Add(numbers[0], numbers[1]);
                break;
            case "-":
                result = Operation.Subtract(numbers[0], numbers[1]);
                break;
            case "*":
                result = Operation.Multiply(numbers[0], numbers[1]);
                break;
            case "/":
                result = Operation.Divide(numbers[0], numbers[1]);
                break;
            default:
                break;
        }


        Std.Summarize(operation, numbers, result);
    }
    static void Main(string[] args)
    {
        Program._Debug();
    }
}
