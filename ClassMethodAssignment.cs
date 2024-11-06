using System;

namespace ClassMethodAssignment
{
    // Static class for mathematical operations
    public static class MathOperations
    {
        // Void method that takes an integer input and outputs half of it
        public static void DivideByTwo(int number, out int result)
        {
            // Divide the input number by 2 and set the output parameter
            result = number / 2;
            // Display the result
            Console.WriteLine("The number divided by two is: " + result);
        }

        // Overloaded method with a different signature, performing addition
        public static int Add(int number1, int number2)
        {
            // Return the sum of the two numbers
            return number1 + number2;
        }

        // Another overload of Add, but this one takes a single integer and adds a default value
        public static int Add(int number1)
        {
            int defaultValue = 10;
            // Return the sum of the number and a default value
            return number1 + defaultValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.Write("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Instantiate the static class and call the method to divide the number by 2
            MathOperations.DivideByTwo(userNumber, out int dividedResult);

            // Call the overloaded Add method with two parameters
            int sumResult = MathOperations.Add(userNumber, 5);
            Console.WriteLine("Sum of your number and 5 is: " + sumResult);

            // Call the overloaded Add method with a single parameter
            int sumWithDefault = MathOperations.Add(userNumber);
            Console.WriteLine("Sum of your number and a default value (10) is: " + sumWithDefault);

            // Hold the console open
            Console.ReadLine();
        }
    }
}