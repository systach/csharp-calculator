using System;

namespace Standards
{
    class Std
    {
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

            string std;

            while (true)
            {
                Console.Write("Choose the operation type: ");
                std = Console.ReadLine() ?? "";

                Console.WriteLine(std);

                if (!optionChars.Contains(std))
                {
                    Console.WriteLine("Invalid operation type. Please choose valid operation type.");
                    continue;
                }

                break;

            }

            return std;
        }

        public static double[] GetTwoNumbersList()
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
                    Console.WriteLine($"!!{e.Message}");
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
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"!!{e.Message}");
                    Console.WriteLine("Invliad numeric value. Please enter valid number.");
                }
            }

            return nums;
        }
    }
}

