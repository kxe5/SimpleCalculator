// See https://aka.ms/new-console-template for more information
using System.Numerics;
/*Console.Beep(1000,100);
Console.BackgroundColor =ConsoleColor.Yellow;
Console.WriteLine("yellow");


Console.BackgroundColor =ConsoleColor.Red;
Console.WriteLine("red");


Console.BackgroundColor =ConsoleColor.Blue;
Console.WriteLine("blue");

Console.ReadLine();*/


using System;

class SimpleCalculator
{
    static void Main(string[] args)
    {
        // Get user input for the numbers
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Get user input for the operation
        Console.Write("Choose an operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        // Perform the operation and display the result
        switch (operation)
        {
            case '+':
                Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operation selected.");
                break;
        }
    }
}

