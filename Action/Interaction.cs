using System;

namespace Action.Interaction;

class Interaction
{

    public static void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
    public static string ReadLine(string printMessage, string errorMessage)
    {
        Console.Write($"{printMessage}: ");
        string value = Console.ReadLine() ?? "".Trim();
        if (string.IsNullOrEmpty(value))
        {
            Console.WriteLine(errorMessage);
            return Interaction.ReadLine(printMessage, errorMessage);
        }
        return value;
    }

    public static double ReadAndParseLine(string printMessage, string errorMessage)
    {
        try
        {
            double value = double.Parse(Interaction.ReadLine(printMessage, errorMessage));
            return value;
        }
        catch (Exception)
        {
            Console.WriteLine(errorMessage);
            return Interaction.ReadAndParseLine(printMessage, errorMessage);
        }
    }
    public static string SelectOperation()
    {
        string[] operations = new string[4] { "+", "-", "*", "/" };
        string operationType = "";
        while (true)
        {
            operationType = Interaction.ReadLine("Select calculator operation ('+', '-', '*', '/')", "[ X ][ 1 ] Invalid operation type.\n[ X ][ 1 ] Please enter one of the operations ('+', '-', '*', '/').");
            if (!operations.Contains(operationType))
            {
                Interaction.WriteLine("[ X ][ 1 ] Invalid operation type.\n[ X ][ 1 ] Please enter one of the operations ('+', '-', '*', '/').");
            }
            else
            {
                break;
            }
        }

        return operationType;
    }
    public static double SelectNumber(string targetString)
    {
        return Interaction.ReadAndParseLine($"Enter {targetString}", $"[ X ][ 2 ] Invalid value for {targetString}.\n[ X ][ 2 ] Please enter valid formatted value.");
    }
}