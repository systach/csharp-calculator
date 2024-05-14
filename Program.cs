using System;
using Action.Interaction;
using Action.Operation;

namespace csharp.calculator;

class Program
{
    static void Main(string[] args)
    {
        Interaction.WriteLine("[ Calcalation Begins ]");
        string operationType = Interaction.SelectOperation();
        double x_1 = Interaction.SelectNumber("first number");
        double x_2 = Interaction.SelectNumber("second number");
        double result = 0;

        switch (operationType)
        {
            case "+":
                result = Operation.Add(x_1, x_2);
                break;
            case "-":
                result = Operation.Subtract(x_1, x_2);
                break;
            case "*":
                result = Operation.Multiply(x_1, x_2);
                break;
            case "/":
                while (true)
                {
                    if (x_2 == 0)
                    {
                        Interaction.WriteLine("[ X ][ 2 ] Zero is not divisible.\n[ X ][ 2 ] Please enter non-zero value.");
                        x_2 = Interaction.SelectNumber("second number");
                    }
                    else
                    {
                        break;
                    }
                }
                result = Operation.Divide(x_1, x_2);
                break;
            default:
                break;

        }
        Interaction.WriteLine($"[ O ][ K ] Calculation Summary\n  [ Operation Type ] {operationType}\n  [ Calculation Expression ] {x_1} {operationType} {x_2}\n  [ Result ] {result}");
        Interaction.WriteLine("[ Calcalation Completed ]");

    }
}