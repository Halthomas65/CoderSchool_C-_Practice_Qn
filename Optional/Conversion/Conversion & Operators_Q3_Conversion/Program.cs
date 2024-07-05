// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.


//Part 1

// Create a program to get the users height in meters and weight in kilograms and calculate the BMI of the user.
// The formula to calculate the BMI is weight / (height * height).
// The program should then display the BMI of the user and display the following message based on the BMI:
// BMI < 18.5: Underweight
// 18.5 <= BMI < 25: Normal
// 25 <= BMI < 30: Overweight
// BMI >= 30: Obese

//Test Data
//Enter your height in meters: 1.75
//Enter your weight in kilograms: 68
//Your BMI is 22.2
//You are Normal
Console.Write("Enter your height in meters: ");
double height = double.Parse(Console.ReadLine());
Console.Write("Enter your weight in kilograms: ");
double weight = double.Parse(Console.ReadLine());
double bmi = weight / (height * height);
Console.WriteLine($"Your BMI is {bmi}");
if (bmi < 18.5)
{
    Console.WriteLine("You are Underweight");
}
else if (bmi < 25)
{
    Console.WriteLine("You are Normal");
}
else if (bmi < 30)
{
    Console.WriteLine("You are Overweight");
}
else
{
    Console.WriteLine("You are Obese");
}


//Part 2

// Modify the program to get the users height in feet and inches and weight in pounds and calculate the BMI of the user.
// The formula to calculate the BMI is (weight * 703) / (height * height).
// The program should then display the BMI of the user and display the following message based on the BMI:
// BMI < 18.5: Underweight
// 18.5 <= BMI < 25: Normal
// 25 <= BMI < 30: Overweight
// BMI >= 30: Obese

//Test Data
//Enter your height in feet: 5
//Enter your height in inches: 9
//Enter your weight in pounds: 150
//Your BMI is 22.1
//You are Normal
Console.Write("Enter your height in feet: ");
int feet = int.Parse(Console.ReadLine());
Console.Write("Enter your height in inches: ");
int inches = int.Parse(Console.ReadLine());
Console.Write("Enter your weight in pounds: ");
int pounds = int.Parse(Console.ReadLine());
double heightInMeters = (feet * 0.3048) + (inches * 0.0254);
double weightInKilograms = pounds * 0.453592;
bmi = weightInKilograms / (heightInMeters * heightInMeters);
Console.WriteLine($"Your BMI is {bmi}");


//Part 3

//In a game, the player's score is stored as an integer, but you need to display it with one decimal place. Convert the player's score from an integer to a double and print the result.

//Test Data
//Player's Score: 100
//Player's Score with one decimal place: 100.0
Console.Write("Player's Score: ");
int score = int.Parse(Console.ReadLine());
double scoreWithOneDecimal = score;
Console.WriteLine($"Player's Score with one decimal place: {scoreWithOneDecimal:0.0}");


//Part 4
//In a game, the player's health is stored as a double, but you need to display it as a percentage (integer value). Convert the player's health from a double to an integer representing a percentage and print the result.

//Test Data
//Player's Health: 0.75
//Player's Health as a percentage: 75%
Console.Write("Player's Health: ");
double health = double.Parse(Console.ReadLine());
int healthPercentage = (int)(health * 100);
Console.WriteLine($"Player's Health as a percentage: {healthPercentage}%");


//Part 5

//In a game, the player's coins are stored as a double, but you need to display them as an integer (rounded down). Convert the player's coins from a double to an integer and print the result.

//Test Data
//Player's Coins: 123.45
//Player's Coins as an integer: 123
Console.Write("Player's Coins: ");
double coins = double.Parse(Console.ReadLine());
int coinsAsInteger = (int)coins;
Console.WriteLine($"Player's Coins as an integer: {coinsAsInteger}");


//Part 6

//In a game, the player's progress is stored as a boolean (true for completed, false for incomplete), but you need to display it as a string ("Completed" or "Incomplete").
//Convert the player's progress from a boolean to a string representing the status and print the result.
//Hint: Use a conditional statement to check the boolean value and return the appropriate string. e.g ., if (progress) { return "Completed"; } else { return "Incomplete"; }

//Test Data
//Player's Progress: true
//Player's Progress as a string: Completed
Console.Write("Player's Progress: ");
bool progress = bool.Parse(Console.ReadLine());
string progressAsString = progress ? "Completed" : "Incomplete";
Console.WriteLine($"Player's Progress as a string: {progressAsString}");
