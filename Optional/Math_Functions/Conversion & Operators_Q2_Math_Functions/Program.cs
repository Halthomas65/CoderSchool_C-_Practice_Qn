Console.WriteLine("Enter the first number: ");
//Part 1
// Use the Math class to calculate the minimum of two numbers.
// Hint: Use the Min method of the Math class.
// Test Data:
// Enter the first number: 5
// Enter the second number: 10
// Expected Output:
// The minimum of 5 and 10 is 5
Console.WriteLine("Part 1.");
Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int min = Math.Min(num1, num2);
Console.WriteLine($"The minimum of {num1} and {num2} is {min}");


//Part 2
// Use the Math class to calculate the maximum of two numbers.
// Hint: Use the Max method of the Math class.
// Test Data:
// Enter the first number: 15
// Enter the second number: 8
// Expected Output:
// The maximum of 15 and 8 is 15
Console.WriteLine("\nPart 2.");
Console.Write("Enter the first number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int num4 = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(num3, num4);
Console.WriteLine($"The maximum of {num3} and {num4} is {max}");


//Part 3
// Use the Math class to calculate the square root of a number.
// Hint: Use the Sqrt method of the Math class.
// Test Data:
// Enter a number: 144
// Expected Output:
// The square root of 144 is 12
Console.WriteLine("\nPart 3.");
Console.Write("Enter a number: ");
int num5 = Convert.ToInt32(Console.ReadLine());
double sqrt = Math.Sqrt(num5);
Console.WriteLine($"The square root of {num5} is {sqrt}");


//Part 4
// Use the Math class to calculate the absolute value of a number.
// Hint: Use the Abs method of the Math class.
// Test Data:
// Enter a number: -5
// Expected Output:
// The absolute value of -5 is 5
Console.WriteLine("\nPart 4.");
Console.Write("Enter a number: ");
int num6 = Convert.ToInt32(Console.ReadLine());
int abs = Math.Abs(num6);
Console.WriteLine($"The absolute value of {num6} is {abs}");


//Part 5
// Use the Math class to calculate the power of a number.
// Hint: Use the Pow method of the Math class.
// Test Data:
// Enter the base number: 2
// Enter the exponent: 5
// Expected Output:
// 2 raised to the power of 5 is 32
Console.WriteLine("\nPart 5.");
Console.Write("Enter the base number: ");
int baseNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the exponent: ");
int exponent = Convert.ToInt32(Console.ReadLine());
double power = Math.Pow(baseNum, exponent);
Console.WriteLine($"{baseNum} raised to the power of {exponent} is {power}");


//Part 6
// Use the Math class to round a number to the nearest integer.
// Hint: Use the Round method of the Math class.
// Test Data:
// Enter a number: 4.6
// Expected Output:
// 4.6 rounded to the nearest integer is 5
Console.WriteLine("\nPart 6.");
Console.Write("Enter a number: ");
double num7 = Convert.ToDouble(Console.ReadLine());
int rounded = (int)Math.Round(num7);
Console.WriteLine($"{num7} rounded to the nearest integer is {rounded}");


//Part 7
// Use the Math class to find the smallest integer greater than or equal to a number.
// Hint: Use the Ceiling method of the Math class.
// Test Data:
// Enter a number: 3.14
// Expected Output:
// The smallest integer greater than or equal to 3.14 is 4
Console.WriteLine("\nPart 7.");
Console.Write("Enter a number: ");
double num8 = Convert.ToDouble(Console.ReadLine());
int ceiling = (int)Math.Ceiling(num8);
Console.WriteLine($"The smallest integer greater than or equal to {num8} is {ceiling}");


//Part 8
// Use the Math class to find the largest integer less than or equal to a number.
// Hint: Use the Floor method of the Math class.
// Test Data:
// Enter a number: 3.14
// Expected Output:
// The largest integer less than or equal to 3.14 is 3
Console.WriteLine("\nPart 8.");
Console.Write("Enter a number: ");
double num9 = Convert.ToDouble(Console.ReadLine());
int floor = (int)Math.Floor(num9);
Console.WriteLine($"The largest integer less than or equal to {num9} is {floor}");


//Part 9
// Use the Math class to calculate e raised to the power of a number.
// Hint: Use the Exp method of the Math class.
// Test Data:
// Enter a number: 2
// Expected Output:
// e raised to the power of 2 is 7.38905609893065
Console.WriteLine("\nPart 9.");
Console.Write("Enter a number: ");
double num10 = Convert.ToDouble(Console.ReadLine());
double exp = Math.Exp(num10);
Console.WriteLine($"e raised to the power of {num10} is {exp}");


//Part 10
// Use the Math class to calculate the natural logarithm of a number.
// Hint: Use the Log method of the Math class.
// Test Data:
// Enter a number: 100
// Expected Output:
// The natural logarithm of 100 is 4.60517018598809
Console.WriteLine("\nPart 10.");
Console.Write("Enter a number: ");
double num11 = Convert.ToDouble(Console.ReadLine());
double log = Math.Log(num11);
Console.WriteLine($"The natural logarithm of {num11} is {log}");


//Part 11
// Generate a random number between 1 and 100 using the Math class.
// Hint: Use the Random method of the Math class.
// Expected Output:
// A random number between 1 and 100 is 56
Console.WriteLine("\nPart 11.");
Random random = new Random();
int randomNum = random.Next(1, 101);
Console.WriteLine($"A random number between 1 and 100 is {randomNum}");