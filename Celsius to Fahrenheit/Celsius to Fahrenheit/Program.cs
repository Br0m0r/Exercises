using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;

namespace Exercise
{
    /*
     * Exercise 2: Temperature Converter
Objective: Write a program that converts temperatures between Fahrenheit and Celsius.

    Requirements:

    Prompt the user to enter a temperature and the unit (Celsius or Fahrenheit).
    Convert the temperature to the other unit and display the result.
    Use the formula C = (F - 32) * 5/9 for Fahrenheit to Celsius conversion, 
    and F = C * 9/5 + 32 for Celsius to Fahrenheit.
    Use conditional statements to handle the logic
    for which conversion to perform based on the user's input.
    */


    public class Program
    {
        
        static void Main(string[] args) 
        {
            Console.WriteLine("Please enter number");
            double n;
            if (double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Press F for : Celsius to Fehrenheit\nPress C for : Fehrenheit to Celsius");
                string s = Console.ReadLine();
                double output;

                if (s == "C" || s == "c")
                    {
                    output = (n - 32) * (5.0 / 9); 
                    Console.Write($"{n}F equals to {output}C");
                    }
                else if (s == "F" || s == "f")
                    {
                    output = n * (9.0 / 5) + 32; 
                    Console.Write($"{n}C equals to {output}F");
                    }
                else
                    {
                        Console.WriteLine("Please press one of the 2 options");
                    }
                 

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }


    }


}