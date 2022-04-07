using System;

namespace Assignment3Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            bool endApp = false;
            double result;
            string op;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Welcome to Console Calculator in C#\r");
            Console.WriteLine("-----------------------------------\n");

            while (!endApp)
            {
                string numInput1;
                string numInput2;

                double cleanNum1;
                double cleanNum2;

                numInput1 = GetUserInput();
                cleanNum1 = ConfirmUserInput(numInput1);

                numInput2 = GetUserInput();
                cleanNum2 = ConfirmUserInput(numInput2);

                Console.WriteLine("Choose an operator from the following list:\n");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide \n");
                Console.Write("Your selection? ");

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "a":
                        result = c1.AddValues(cleanNum1, cleanNum2);
                        op = "+";
                        PrintResult(result, cleanNum1, cleanNum2, op);
                        break;
                    case "s":
                        result = c1.SubstractValues(cleanNum1, cleanNum2);
                        op = "-";
                        PrintResult(result, cleanNum1, cleanNum2, op);
                        break;
                    case "m":
                        result = c1.MultiplyValues(cleanNum1, cleanNum2);
                        op = "*";
                        PrintResult(result, cleanNum1, cleanNum2, op);
                        break;
                    case "d":
                        result = c1.DivideValues(cleanNum1, cleanNum2);
                        op = "/";
                        if (result != 0)
                        PrintResult(result, cleanNum1, cleanNum2, op);
                        break;
                    default:
                        Console.WriteLine("Not a valid selection, please try again");
                        break;
                }

                Console.WriteLine("------------------------\n");


                Console.Write("Press 'e' and Enter to exit the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "e") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
        public static void PrintResult(double result, double num1, double num2, string op)
        {
            Console.WriteLine($"{num1} {op} {num2} = {result}");
        }

        public static string GetUserInput()
        {
            Console.Write("Type a number, and then press Enter: ");
            return Console.ReadLine();
        }

        public static double ConfirmUserInput(string numInput)
        {
            double cleanNum = 0;
            while (!double.TryParse(numInput, out cleanNum))
            {
                Console.Write("This is not valid input. Please enter a number: ");
                numInput = Console.ReadLine();
            }
            return cleanNum;
        }
    }     
}
