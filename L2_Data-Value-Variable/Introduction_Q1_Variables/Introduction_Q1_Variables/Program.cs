// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.



//---------------------------------------------------------------------
// Part 1: Create variables of different types, assign values to them, and print them to the console
// Hint: Use the Console.WriteLine() method to print the string to the console.
// Create variables of different types and assign values to them using a consistent naming convention.
// Use the following variable types: int, double, string, bool, char, byte, long, decimal, float.

// int variable
// Create an integer variable named 'enemy_health' and assign it the value 100.
// This variable type is used to store whole numbers.
int enemy_health = 100;
Console.WriteLine($"Enemy Health: {enemy_health}");

// double variable
// Create a double variable named 'game_currency' and assign it the value 2500.50.
// This variable type is used to store decimal numbers.
double game_currency = 2500.50;
Console.WriteLine($"Game Currency: {game_currency}");

// string variable
// Create a string variable named 'player_name' and assign it the value "John Doe".
// This variable type is used to store text.
string player_name = "John Doe";
Console.WriteLine($"Player Name: {player_name}");

// bool variable
// Create a boolean variable named 'isalive' and assign it the value true.
// This variable type is used to store true or false values.
bool isalive = true;
Console.WriteLine($"Is Alive: {isalive}");

// char variable
// Create a character variable named 'patrol_state' and assign it the value 'S' for "Standby".
// This variable type is used to store single characters.
char patrol_state = 'S';
Console.WriteLine($"Patrol State: {patrol_state}");

// Byte variable
// Create a byte variable named 'player_age' and assign it the value 25.
// This variable type is used to store whole numbers from 0 to 255.
byte player_age = 25;
Console.WriteLine($"Player Age: {player_age}");

// Long variable
// Create a long variable named 'score' and assign it the value 1000000000.
// This variable type is used to store whole numbers.
long score = 1000000000;
Console.WriteLine($"Score: {score}");

// Decimal variable
// Create a decimal variable named 'price' and assign it the value 100.50.
// This variable type is used to store decimal numbers.
decimal price = 100.50m;
Console.WriteLine($"Price: {price}");

// Null variable
// Create a variable named 'null_variable' and assign it the value null.
// This variable type is used to store no value.
object null_variable = null;
Console.WriteLine($"Null Variable: {null_variable}");

// Float variable
// Create a float variable named 'speed' and assign it the value 100.50.
// This variable type is used to store decimal numbers.
float speed = 100.50f;
Console.WriteLine($"Speed: {speed}");
//---------------------------------------------------------------------
Console.WriteLine("\n---------------------------------------------------------------------\n");

// Part 17: Declaration of Constants
// Write a C# program to declare a constant integer variable representing the value of Pi.
// Hint: Use the const keyword to declare the constant.
// Test data: const double Pi = 3.14159;
const double Pi = 3.14159265;
Console.WriteLine($"Value of Pi: {Pi}");

// Part 18: Declaration of Constants
// Write a C# program to declare a constant string variable representing the name of a company.
// Hint: Use the const keyword to declare the constant.
// Test data: const string CompanyName = "ABC Corporation";
const string CompanyName = "ABC Corporation";
Console.WriteLine($"Company Name: {CompanyName}");

// Part 19: Declaration of Constants
// Write a C# program to declare a constant integer variable representing the maximum number of retries for a network request.
// Hint: Use the const keyword to declare the constant.
// Test data: const int MaxRetries = 3;
const int MaxRetries = 3;
Console.WriteLine($"Max Retries: {MaxRetries}");

// Part 20: Declaration of Constants
// Write a C# program to declare a constant double variable representing the acceleration due to gravity.
// Hint: Use the const keyword to declare the constant.
// Test data: const double Gravity = 9.8;
const double Gravity = 9.8;
Console.WriteLine($"Acceleration due to Gravity: {Gravity}");

// Part 21: Declaration of Constants
// Write a C# program to declare a constant integer variable representing the number of months in a year.
// Hint: Use the const keyword to declare the constant.
// Test data: const int MonthsInYear = 12;
const int MonthsInYear = 12;
Console.WriteLine($"Months in a Year: {MonthsInYear}");