using System;
using System.Runtime.CompilerServices;
using Math;
using Standards;

namespace csharp.calculator;

class Program
{
    static void _Debug_Evaluation()
    {
        double slope = Std.GetSlope();
        double intercept = Std.GetIntercept();
        LinearFunction linearFunction = new LinearFunction(slope, intercept);
        double valueToEvaluate = Std.GetValueToEvaluate();
        linearFunction.Evaluate(valueToEvaluate);

        Std.SummarizeEvaluation(linearFunction, valueToEvaluate);
    }
    static void _Debug_Calculation()
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


        Std.SummarizeCalculation(operation, numbers, result);
    }
    static void Main(string[] args)
    {
        string key = args[0];

        if (string.IsNullOrWhiteSpace(key.Trim()))
        {
            Std.Write("Run flag '-' must be entered with followed from 'dotnet run'. Try again.");
            return;
        }

        switch (key)
        {
            case "calc":
                Program._Debug_Calculation();
                break;
            case "eval":
                Program._Debug_Evaluation();
                break;
            default:
                Std.Write($"The flag --{key} is unknown. Try again.");
                return;
        }
    }
}
