
using System;

namespace MethodClassAssignment
{
    public class MathOperations
    {
        // This void method takes two integers as parameters.
        // It performs a math operation on the first integer
        // and displays the second integer to the console.
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Perform a simple math operation on the first number.
            // Here, we multiply it by 2 just as an example.
            int result = firstNumber * 2;

            // Display the result of the math operation.
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second number to the screen.
            Console.WriteLine("Second number is: " + secondNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class so we can use its method.
            MathOperations mathOps = new MathOperations();

            // Call the method, passing in two numbers normally.
            mathOps.ProcessNumbers(10, 25);

            // Call the method again, this time specifying parameter names.
            mathOps.ProcessNumbers(firstNumber: 7, secondNumber: 14);

            // Keep the console window open until a key is pressed.
            Console.ReadLine();
        }
    }
}

