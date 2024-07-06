
// Guide to Exceptions in C#:

// System.ArgumentNullException:
// - Thrown when a null argument is passed to a method that does not accept null arguments.

// System.FormatException:
// - Thrown when a method is called with an invalid format for its input arguments.

// System.IndexOutOfRangeException:
// - Thrown when an attempt is made to access an element of an array or collection with an index outside the bounds.

// System.InvalidCastException:
// - Thrown when an invalid type conversion is attempted.

// System.IO.IOException:
// - Thrown when an I/O error occurs, such as when reading from or writing to a file.

// System.DivideByZeroException:
// - Thrown when attempting to divide an integer or decimal number by zero.

// System.NullReferenceException:
// - Thrown when attempting to access a member of a null object reference.

// System.OverflowException:
// - Thrown when an arithmetic operation results in an overflow.

// System.NotImplementedException:
// - Thrown when a method or feature is not yet implemented.

// System.OutOfMemoryException:
// - Thrown when attempting to allocate memory fails due to insufficient available memory.

// System.StackOverflowException:
// - Thrown when the execution stack overflows, typically due to excessive recursion.

// System.TimeoutException:
// - Thrown when an operation times out before completing.

// System.ArgumentException:
// - Thrown when one or more arguments provided to a method are invalid or out of range.

// System.ArithmeticException:
// - Thrown for errors in arithmetic operations.

// System.Security.SecurityException:
// - Thrown when a security violation occurs, such as attempting to perform an operation that requires elevated permissions.



public class Program
{
    public static void Main()
    {
        int num1, num2;
        int result;

        //Part 1
        //Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.
        //Hint: Use the TryParse method to convert the input string to a number.
        //Hint:Use FormatException for non-numeric values and DivideByZeroException for division by zero.
        Console.WriteLine("Part 1.");
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();
        if (!int.TryParse(input1, out num1) || !int.TryParse(input2, out num2))
        {
            Console.WriteLine("Error: Non-numeric values entered.");
        }
        else
        {
            try
            {
                result = num1 / num2;
                Console.WriteLine($"The result of {num1} / {num2} is {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        //Part 2
        // Write a C# program that reads a string from the user and converts it to an integer. Handle the exception if the input cannot be parsed into an integer.
        //Hint: Use the TryParse method to convert the input string to an integer.
        //Hint: Use FormatException for invalid input.
        Console.WriteLine("Part 2.");
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number;
        if (!int.TryParse(input, out number))
        {
            Console.WriteLine("Error: Invalid input.");
        }
        else
        {
            Console.WriteLine($"The number entered is: {number}");
        }


        //Part 3
        //Write a C# program that implements a method that divides two numbers. Handle the DivideByZeroException that occurs if the denominator is 0.
        //Hint: Use a try-catch block to catch the DivideByZeroException.
        num1 = 10;
        num2 = 0;
        Console.WriteLine("Part 3.");
        Console.WriteLine("Try deviding 10 by 0");
        result = Divide(num1, num2);
        Console.WriteLine($"The result of {num1} / {num2} is {result}");



        //Part 4
        //Write a C# program that creates a method that takes a string as input and converts it to uppercase. Handle the NullReferenceException that occurs if the input string is null.
        //Hint: Use a try-catch block to catch the NullReferenceException.
        Console.WriteLine("Part 4.");
        string str = null;
        Console.WriteLine("Try converting null to uppercase");
        string upcaseStr = ConvertToUppercase(str);
        Console.WriteLine($"The result is: {upcaseStr}");
    }

    static int Divide(int numerator, int denominator)
    {
        try
        {
            return numerator / denominator;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return 0;
        }
    }

    static string ConvertToUppercase(string input)
    {
        try
        {
            return input.ToUpper();
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return string.Empty;
        }
    }
}