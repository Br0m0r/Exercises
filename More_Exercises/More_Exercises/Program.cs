
namespace Exercises
{
    /*
Exercise 1: Simple Calculator
Objective: Create a simple console calculator that can perform basic arithmetic operations (addition, subtraction, multiplication, division) between two numbers.

Requirements:

Prompt the user to enter two numbers.
Ask the user to choose an operation (addition, subtraction, multiplication, division).
Perform the operation and display the result.
Use appropriate data types for storing numbers and the result.
Handle division by zero with a friendly error message.
*/


    class Program
    { 

        static void Main(string[] args) 
        {
            string s;
            do
            {
               
                int b;
                int a;
                Console.WriteLine("Please enter first number");
                int.TryParse(Console.ReadLine(), out a);
                /*
                 if (!int.TryParse(Console.ReadLine(), out a))
                        {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue; // Skip the rest of the loop and prompt the user again
                        }
                */
                Console.WriteLine("Please enter second number");
                int.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("Specify what calculation you want to do");
                Console.WriteLine("type '+' for addition\ntype '-' for subtraction\ntype" +
                    "'*' for multiplication\ntype '/' for division\n");
                string c = Console.ReadLine();
                switch (c)
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;

                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    /*
                    case "/":
                                    if (b != 0)
                                    {
                                        Console.WriteLine($"{a} / {b} = {a / b}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cannot divide by zero.");
                                    }
                                    break; 
                    */

                    case "*":
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;
                }
                Console.WriteLine("\nif you want to do another calculation,type 'y' else type 'n'");
                s = Console.ReadLine();
            } while (s == "y"); //} while (s.Equals("y", StringComparison.OrdinalIgnoreCase));








        }

    }
































}