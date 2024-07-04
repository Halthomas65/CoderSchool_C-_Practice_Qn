public class Program
{
    //---------------------------------------------------------------------
    // Part 1: Displaying a Welcome Message
    // Create a user-defined function to display a welcome message.
    // Hint: Define a function named DisplayWelcomeMessage() that prints the welcome message to the console.
    static public void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome!");
    }

    //---------------------------------------------------------------------
    // Part 2: Personalized Welcome Message
    // Create a user-defined function with parameters to personalize a welcome message.
    // Hint: Define a function named PersonalizedWelcomeMessage() that takes a name as a parameter and prints a personalized welcome message to the console.
    static public void PersonalizedWelcomeMessage(string name)
    {
        Console.WriteLine("Welcome, " + name + "!");
    }

    //---------------------------------------------------------------------
    // Part 3: Calculating the Sum of Two Numbers
    // Create a user-defined function to calculate the sum of two numbers.
    // Hint: Define a function named CalculateSum() that takes two parameters, adds them, and returns the result.
    static public int CalculateSum(int num1, int num2)
    {
        return num1 + num2;
    }

    //---------------------------------------------------------------------
    // Part 4: Counting Spaces in a String
    // Create a user-defined function to count the number of spaces in a string.
    // Hint: Define a function named CountSpaces() that takes a string as a parameter, counts the number of spaces, and returns the count.
    static public int CountSpaces(string text)
    {
        int spaceCount = 0;
        foreach (char c in text)
        {
            if (c == ' ')
            {
                spaceCount++;
            }
        }
        return spaceCount;
    }

    //---------------------------------------------------------------------
    // Part 5: Calculating the Sum of Elements in an Array
    // Create a user-defined function to calculate the sum of elements in an array.
    // Hint: Define a function named CalculateArraySum() that takes an array as a parameter, calculates the sum of its elements, and returns the sum.
    static public int CalculateArraySum(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    //---------------------------------------------------------------------
    // Part 6: Swapping Two Integer Numbers
    // Create a user-defined function to swap two integer numbers.
    // Hint: Define a function named SwapNumbers() that takes two integer parameters, swaps their values, and prints the updated values to the console.
    static public void SwapNumbers(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    //---------------------------------------------------------------------
    // Part 7: Calculating Exponentiation
    // Create a user-defined function to calculate the result of raising an integer number to another.
    // Hint: Define a function named CalculateExponent() that takes two integer parameters (base and exponent), calculates the result, and prints it to the console.
    static public void CalculateExponent(int baseNum, int exponent)
    {
        long result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }
        Console.WriteLine(result);
    }

    //---------------------------------------------------------------------
    // Part 8: Displaying the Fibonacci Sequence
    // Create a user-defined function to display the Fibonacci sequence up to a specified number of terms.
    // Hint: Define a function named DisplayFibonacciSequence() that takes an integer parameter (number of terms), calculates and prints the Fibonacci sequence to the console.
    static public void DisplayFibonacciSequence(int terms)
    {
        int num1 = 0, num2 = 1;
        Console.Write(num1 + " " + num2 + " ");
        for (int i = 2; i < terms; i++)
        {
            int num3 = num1 + num2;
            Console.Write(num3 + " ");
            num1 = num2;
            num2 = num3;
        }
    }

    //---------------------------------------------------------------------
    // Part 9: Checking Prime Numbers
    // Create a user-defined function to check whether a number is prime or not.
    // Hint: Define a function named CheckPrimeNumber() that takes an integer parameter, checks if it's prime, and prints the result to the console.
    static public void CheckPrimeNumber(int number)
    {
        bool isPrime = true;
        if (number == 0 || number == 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }

    //---------------------------------------------------------------------
    // Part 10: Calculating the Sum of Individual Digits
    // Create a user-defined function to calculate the sum of individual digits of a given number.
    // Hint: Define a function named CalculateDigitSum() that takes an integer parameter, calculates the sum of its digits, and prints the result to the console.
    static public void CalculateDigitSum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine("Sum of digits: " + sum);
    }

    //---------------------------------------------------------------------
    // Part 11: Testing Named Parameters in C#
    // Write a C# program that defines a method called "DisplayInfo" that takes two parameters: "name" and "age".
    // Use named parameters to call the "DisplayInfo" method with the parameter values "name"="John" and "age"=30.
    // Hint: Define the method "DisplayInfo" with parameters "name" and "age", then call it using named parameters.
    static public void DisplayInfo(string name, int age)
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }

    //---------------------------------------------------------------------
    // Part 12: Testing Out Parameters in C#
    // Write a C# program that defines a method called "GetSquareRoot" that calculates the square root of a number.
    // Use an out parameter to return the square root of a given number.
    // Hint: Define the method "GetSquareRoot" with an out parameter to store the result.
    static public void GetSquareRoot(double number, out double result)
    {
        result = Math.Sqrt(number);
    }

    //---------------------------------------------------------------------
    // Part 13: Testing Default or Optional Parameters in C#
    // Write a C# program that defines a method called "GreetUser" with two parameters: "name" and "greetingMessage".
    // Set the default value of "greetingMessage" to "Hello".
    // Call the "GreetUser" method with only the "name" parameter provided.
    // Hint: Define the method "GreetUser" with a default value for one of its parameters.
    static public void GreetUser(string name, string greetingMessage = "Hello")
    {
        Console.WriteLine(greetingMessage + ", " + name + "!");
    }

    static void Main(string[] args)
    {
        // Call the DisplayWelcomeMessage() function
        DisplayWelcomeMessage();

        // Call the PersonalizedWelcomeMessage() function with a name parameter
        PersonalizedWelcomeMessage("Alice");

        // Call the CalculateSum() function with two integer parameters
        int sum = CalculateSum(5, 3);
        Console.WriteLine("Sum: " + sum);

        // Call the CountSpaces() function with a string parameter
        int spaces = CountSpaces("Hello, World!");
        Console.WriteLine("Spaces: " + spaces);

        // Call the CalculateArraySum() function with an integer array parameter
        int[] numbers = { 1, 2, 3, 4, 5 };
        int arraySum = CalculateArraySum(numbers);
        Console.WriteLine("Array Sum: " + arraySum);

        // Call the SwapNumbers() function with two integer parameters
        int num1 = 10, num2 = 20;
        Console.WriteLine("Before Swap: " + num1 + ", " + num2);
        SwapNumbers(ref num1, ref num2);
        Console.WriteLine("After Swap: " + num1 + ", " + num2);

        // Call the CalculateExponent() function with two integer parameters
        Console.Write("Exponent: 2^5 =");
        CalculateExponent(2, 5);

        // Call the DisplayFibonacciSequence() function with an integer parameter
        Console.WriteLine("Fibonacci Sequence 10 terms:");
        DisplayFibonacciSequence(10);

        // Call the CheckPrimeNumber() function with an integer parameter
        Console.WriteLine("\nPrime Number:");
        CheckPrimeNumber(17);

        // Call the CalculateDigitSum() function with an integer parameter
        CalculateDigitSum(12345);

        // Call the DisplayInfo() method using named parameters
        DisplayInfo(name: "John", age: 30);

        // Call the GetSquareRoot() method using an out parameter
        double number = 16;
        double squareRoot;
        GetSquareRoot(number, out squareRoot);
        Console.WriteLine("Square Root: " + squareRoot);

        // Call the GreetUser() method with only the "name" parameter
        GreetUser("Bob");
        
    }
}