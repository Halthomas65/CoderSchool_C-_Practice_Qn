//Example of Try-Catch Block:

//try
//{
//    // Code that might throw an exception
//}
//catch (ExceptionType1 ex)
//{
//    // Code to handle ExceptionType1
//}
//catch (ExceptionType2 ex)
//{
//    // Code to handle ExceptionType2
//}
//finally
//{
//    // Code that always runs, regardless of exceptions
//}




// Question 1
// Write a C# program that attempts to divide two numbers and prints any exceptions that may occur.
// Hint: Use a try block to perform the division and a catch block to print any exceptions.
// Test Data: Dividing 10 by 0
try {
    int num1 = 10;
    int num2 = 0;
    int result = num1 / num2;
    Console.WriteLine(result);
}
catch (DivideByZeroException ex) {
    Console.WriteLine("Error: " + ex.Message);
}


// Question 2
// Create a program that converts a string to an integer and prints any exceptions that may occur.
// Hint: Use a try block to convert the string to an integer and a catch block to print any exceptions.
// Test Data: Converting 'abc' to an integer
try {
    string str = "abc";
    int num = Convert.ToInt32(str);
    Console.WriteLine(num);
}
catch (FormatException ex) {
    Console.WriteLine("Error: " + ex.Message);
}

// Question 3
// Write a C# program that opens a file and prints any exceptions that may occur.
// Hint: Use a try block to open the file and a catch block to print any exceptions.
// Test Data: Opening a non-existent file
try {
    string filePath = "NonExistentFile.txt";
    using (StreamReader sr = new StreamReader(filePath)) {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (FileNotFoundException ex) {
    Console.WriteLine("Error: " + ex.Message);
}

// Question 4
// Create a program that reads input from the user and prints any exceptions that may occur.
// Hint: Use a try block to read input from the user and a catch block to print any exceptions.
// Test Data: Reading input from the user
try {
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num);
}
catch (FormatException ex) {
    Console.WriteLine("Error: " + ex.Message);
}
catch (OverflowException ex) {
    Console.WriteLine("Error: " + ex.Message);
}
catch (Exception ex) {
    Console.WriteLine("Error: " + ex.Message);
}

// Question 5
// Write a C# program that performs a calculation and prints any exceptions that may occur.
// Hint: Use a try block to perform the calculation and a catch block to print any exceptions.
// Test Data: Performing a calculation with invalid operands
try {
    int num1 = int.MaxValue;
    int num2 = 1;
    int result = num1 + num2;
    Console.WriteLine(result);
}
catch (OverflowException ex) {
    Console.WriteLine("Error: " + ex.Message);
}