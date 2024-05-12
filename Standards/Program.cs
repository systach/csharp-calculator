using System;

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

        public static void Summarize(string operation, double[] nums, double result)
        {
            Std.Write("Calculation completed.");
            Std.Write($"Operation-Type: {operation}");
            Std.Write($"Expression: {nums[0]} {operation} {nums[1]}");
            Std.Write($"Result: {result}");
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
                        throw new DivideByZeroException("The denominator cannot be set to zero. Please try again.");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"*{e.Message}");
                    Console.WriteLine("Invliad numeric value. Please enter valid number.");
                }
            }

            return nums;
        }
    }
}

