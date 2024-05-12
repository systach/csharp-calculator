using System;

namespace Library.Std;

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

    public static List<int> GetTwoNumbers()
    {
        List<int> nums = new List<int>();

        int temp;

        while (true)
        {
            try
            {
                Console.Write("Enter the first number: ");
                temp = int.Parse(Console.ReadLine() ?? "");
                nums.Add(temp);
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
                temp = int.Parse(Console.ReadLine() ?? "");
                nums.Add(temp);
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