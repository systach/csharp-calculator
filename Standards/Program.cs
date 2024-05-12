using System;
using Math;

namespace Standards
{
    class Std
    {
        public static void Write(string message, string end = "\n")
        {
            if (end.Equals("\n"))
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"{message}{end}");
            }
        }

        public static double GetSlope()
        {
            double slope;

            while (true)
            {
                Console.Write("Enter the slope: ");
                try
                {
                    bool parsable = double.TryParse(Console.ReadLine() ?? "", out slope);
                    if (!parsable)
                    {
                        throw new FormatException("The slope must be a double format.");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"*{e.Message}");
                    Console.WriteLine("Error caught as described above. Please try again.");
                }

            }

            return slope;
        }

        public static double GetIntercept()
        {

            double intercept;

            while (true)
            {
                Console.Write("Enter the intercept: ");
                try
                {
                    bool parsable = double.TryParse(Console.ReadLine() ?? "", out intercept);
                    if (!parsable)
                    {
                        throw new FormatException("The intercept must be a double format.");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"*{e.Message}");
                    Console.WriteLine("Error caught as described above. Please try again.");
                }

            }

            return intercept;
        }

        public static double GetValueToEvaluate()
        {

            double value;

            while (true)
            {
                Console.Write("Enter the value to evaluate: ");
                try
                {
                    bool parsable = double.TryParse(Console.ReadLine() ?? "", out value);
                    if (!parsable)
                    {
                        throw new FormatException("The value must be a double format.");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"*{e.Message}");
                    Console.WriteLine("Error caught as described above. Please try again.");
                }

            }

            return value;
        }

        public static void SummarizeEvaluation(LinearFunction linearFunction, double value)
        {
            Std.Write("[O] Evaluation completed.");
            Std.Write($"\tFunction Expression: f(x) = {linearFunction.GetSlope()}x + {linearFunction.GetIntercept()}");
            Std.Write($"\tValue to Evaluate: {value}");
            Std.Write($"\tResult: {linearFunction.Evaluate(value)}");
        }

        public static void SummarizeCalculation(string operation, double[] nums, double result)
        {
            Std.Write("[O] Calculation completed.");
            Std.Write($"\tOperation-Type: {operation}");
            Std.Write($"\tExpression: {nums[0]} {operation} {nums[1]}");
            Std.Write($"\tResult: {result}");
        }
        public static string GetOperationOption()
        {
            string[] options = [
                "[+] Addition",
            "[-] Subtraction",
            "[*] Multiplication",
            "[/] Division"
            ];

            string[] optionChars = [
                "+",
            "-",
            "*",
            "/"
            ];

            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            string operation;

            while (true)
            {
                Console.Write("Choose the operation type: ");
                operation = Console.ReadLine() ?? "";

                if (!optionChars.Contains(operation))
                {
                    Console.WriteLine("Invalid operation type. Please choose valid operation type.");
                    continue;
                }

                break;

            }

            return operation;
        }

        public static double[] GetTwoNumbersList(string operation)

        {
            double[] nums = new double[2];

            double temp;

            while (true)
            {
                try
                {
                    Console.Write("Enter the first number: ");
                    temp = double.Parse(Console.ReadLine() ?? "");
                    nums[0] = temp;
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\t--{e.Message}--");
                    Console.WriteLine("Invliad numeric value. Please enter valid number.");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter the second number: ");
                    temp = double.Parse(Console.ReadLine() ?? "");
                    nums[1] = temp;
                    if (operation.Equals("/") && nums[1] == 0)
                    {
                        throw new DivideByZeroException("The denominator cannot be set to zero.");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"*{e.Message}");
                    Console.WriteLine("Error caught as described above. Please try again.");
                }
            }

            return nums;
        }
    }
}

