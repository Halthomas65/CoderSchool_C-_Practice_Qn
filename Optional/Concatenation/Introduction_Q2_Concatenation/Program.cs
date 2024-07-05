// using System;
// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.



//Part 1
//Write a C# program that concatenates two strings (player's first and last name) and then outputs the result.
//Hint: You can assign a string to a variable using the = operator.
//Hint: You can use the + operator to concatenate two strings.
//Hint: You can use the Console.WriteLine() method to output the result.
string firstName0 = "John";
string lastName0 = "Wick";
string fullName0 = firstName0 + " " + lastName0;
Console.WriteLine("Full name: " + fullName0);

//Part 2
//Modify the program so that it gets the two strings from the user(for username).
//Hint: You can use the Console.ReadLine() method to get a string from the user.
//Hint: You can use the Console.WriteLine() method to prompt the user for input.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("\nEnter your first name: ");
string firstName = Console.ReadLine();
Console.WriteLine("Enter your last name: ");
string lastName = Console.ReadLine();
string fullName = firstName + " " + lastName;
Console.WriteLine("Your name is " + fullName);

//Part 3
//Modify the program so that it concatenates three strings instead of two (clan name).
//Hint: You can use the + operator to concatenate three strings.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Enter your clan name: ");
string clanName = Console.ReadLine();
fullName = firstName + " " + lastName + " of clan " + clanName;
Console.WriteLine("You are " + fullName);

//Part 4
//Modify the program to concatenate a string and an integer(incase,player name had numebrs).
//Hint: You can use the + operator to concatenate a string and an integer.
//Hint: You can use the Console.ReadLine() method to get an integer from the user.
//Hint: You can use the int.Parse() method to convert a string to an integer.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine());
fullName = firstName + " " + lastName + " of clan " + clanName + ", aged " + age;
Console.WriteLine("You are " + fullName);