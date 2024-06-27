// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.

using System.Text.RegularExpressions;

// These variables are for part 1 to part 3
string str1 = "Hello";
string str2 = "World";
string str3 = "ehe!";
string result;

//Part 1
//Create a program so that it concatenates three strings and then outputs the result in uppercase.
//Hint: You can use the ToUpper() method to convert a string to uppercase.
//Hint: You can use the Console.WriteLine() method to output the result.
result = str1 + " " + str2 + " " + str3;
Console.WriteLine(result.ToUpper());


//Part 2
//Create a program so that it concatenates three strings and then outputs the result in lowercase.
//Hint: You can use the ToLower() method to convert a string to lowercase.
//Hint: You can use the Console.WriteLine() method to output the result.
// result = str1 + " " + str2 + " " + str3;
Console.WriteLine(result.ToLower());

//Part 3
//Write a program to find the length of a string.
//Hint: You can use the Length property to find the length of a string.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Length or the string: " + result.Length);

//Part 4
//Write a program to find the index of a character in a string.
//Hint: You can use the IndexOf() method to find the index of a character in a string.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Index of 'o' in the string: " + result.IndexOf('o'));

//Part 5
//Write a program to find the index of a character in a string starting from a specified position.
//Hint: You can use the IndexOf() method to find the index of a character in a string starting from a specified position.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Index of 'o' in the string starting from position 5: " + result.IndexOf('o', 5));

//Part 6
//Write a program to count the occurrences of a specific character in a string.
//Hint: You can use the Count() method to count the occurrences of a specific character in a string.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Number of 'e' in the string: " + result.Count(x => x == 'e'));

//Part 7
//Write a program to replace a character in a string with another character.
//Hint: You can use the Replace() method to replace a character in a string with another character.
//Hint: You can use the Console.WriteLine() method to output the result.
int index = result.IndexOf('e'); // Find the index of the first 'e'
if (index != -1) // Check if 'e' is found
{
    result = result.Substring(0, index) + 'a' + result.Substring(index + 1);
}
Console.WriteLine("After replacing one 'e' with 'a': " + result);

//Part 8
//Write a program to remove a character from a string.
//Hint: You can use the Remove() method to remove a character from a string.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Remove 'e' from the string: " + result.Remove(result.IndexOf('e'), 1));

//Part 9
//Write a program to replace all occurrences of a specific character in a string with another character.
//Hint: You can use the Replace() method to remove all occurrences of a specific character from a string.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Replace all 'l' with 'r': " + result.Replace('l', 'r'));

//Part 10
//Write a program to extract a substring from a string.
//Hint: You can use the Substring() method to extract a substring from a string.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Extract substring from position 6: " + result.Substring(6));

//Part 11
//Write a program to extract a substring from a string starting from a specified position.
//Hint: You can use the Substring() method to extract a substring from a string starting from a specified position.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("Extract substring from position 6 with length 5: " + result.Substring(6, 5));

//Part 12
//Write a program to remove leading and trailing whitespace from a string.
//Hint: You can use the Trim() method to remove leading and trailing whitespace from a string.
//Hint: You can use the Console.WriteLine() method to output the result.
string str4 = "  Hello World!  ";
Console.WriteLine("Before trimming: " + str4);
Console.WriteLine("After trimming: " + str4.Trim());

//Part 13 
//Write a program to parse a string to a number.
//Hint: You can use the Parse() method to parse a string to a number.
//Hint: You can use the Console.WriteLine() method to output the result.
string str5 = "123";
int number = int.Parse(str5);
Console.WriteLine("Parsed number: " + number);

//Part 14
//Write a program to convert a number to a string.
//Hint: You can use the ToString() method to convert a number to a string.
//Hint: You can use the Console.WriteLine() method to output the result.
int number2 = 456;
string str6 = number2.ToString();
Console.WriteLine("Converted string: " + str6);








//////////////////Formating////////////////////
Console.WriteLine("\n//////////////////Formating////////////////////\n");




// Part 1

// You're organizing a team outing and need to print personalized event invitations.
// Develop a C# program that uses placeholders to create customized invitations.
// Replace the placeholders with the recipient's name, event date, and current time.
// Hint: Use composite formatting with placeholders to create personalized invitations.
// Test Data:
// Recipient's name: Alice
// Event date: January 15, 2025
// Expected Output:
// Hello, Alice! You're invited to our team outing on January 15, 2025. The event starts at 09:00.
var recipentName = "Alice";
var eventDate = "January 15, 2025";
var currentTime = "09:00";
var invitation = "Hello, {0}! You're invited to our team outing on {1}. The event starts at {2}.";
Console.WriteLine(invitation, recipentName, eventDate, currentTime);


// Part 2

// Imagine you're managing an online store and need to send order confirmation emails.
// Write a C# program that utilizes placeholders to generate order confirmation emails.
// Fill in the placeholders with the customer's name, order ID, and purchase details.
// Hint: Use composite formatting with placeholders to generate order confirmation emails.
// Test Data:
// Customer's name: John Doe
// Order ID: 123456
// Purchase details: 2 x T-shirts, 3 x Jeans
// Expected Output:
// Dear John Doe, your order (ID: 123456) has been confirmed. You've purchased: 2 x T-shirts, 3 x Jeans.
var customerName = "John Doe";
var orderID = 123456;
var purchaseDetails = "2 x T-shirts, 3 x Jeans";
var orderConfirmation = "Dear {0}, your order (ID: {1}) has been confirmed. You've purchased: {2}.";
Console.WriteLine(orderConfirmation, customerName, orderID, purchaseDetails);


// Part 3

// Picture yourself developing a task management application and need to display task reminders.
// Create a C# program that employs placeholders to format task reminder messages.
// Populate the placeholders with the task name, due date, and priority level.
// Hint: Use composite formatting with placeholders to format task reminder messages.
// Test Data:
// Task name: Complete Project Proposal
// Due date: May 10, 2025
// Priority level: High
// Expected Output:
// Reminder: Complete Project Proposal is due on May 10, 2025. Priority: High.
var taskName = "Complete Project Proposal";
var dueDate = "May 10, 2025";
var priorityLevel = "High";
var taskReminder = "Reminder: {0} is due on {1}. Priority: {2}.";
Console.WriteLine(taskReminder, taskName, dueDate, priorityLevel);


// Part 4

// You're working on a scheduling application and need to generate event reminders.
// Develop a C# program that utilizes placeholders to format event reminder notifications.
// Fill in the placeholders with the event title, location, and start time.
// Hint: Use composite formatting with placeholders to format event reminder notifications.
// Test Data:
// Event title: Team Meeting
// Location: Conference Room A
// Start time: 10:00 AM
// Expected Output:
// Reminder: Team Meeting at Conference Room A starts at 10:00 AM.
var eventTitle = "Team Meeting";
var location = "Conference Room A";
var startTime = "10:00 AM";
var eventReminder = "Reminder: {0} at {1} starts at {2}.";
Console.WriteLine(eventReminder, eventTitle, location, startTime);


// Part 5

// Imagine you're designing a travel app and need to provide flight departure information.
// Write a C# program that employs placeholders to format flight departure notifications.
// Populate the placeholders with the flight number, departure airport, and scheduled time.
// Hint: Use composite formatting with placeholders to format flight departure notifications.
// Test Data:
// Flight number: ABC123
// Departure airport: JFK International Airport
// Scheduled time: 08:30 AM
// Expected Output:
// Flight ABC123 departing from JFK International Airport is scheduled for 08:30 AM.
var flightNumber = "ABC123";
var departureAirport = "JFK International Airport";
var scheduledTime = "08:30 AM";
var departureNotification = "Flight {0} departing from {1} is scheduled for {2}.";
Console.WriteLine(departureNotification, flightNumber, departureAirport, scheduledTime);


// Part 6

// You're developing a messaging application and want to greet the user.
// Write a C# program that asks the user to enter their name.
// Then, use interpolation to display a personalized greeting message.
// Hint: Use the Console.ReadLine() method to get user input and string interpolation to format the message.
// Test Data:
// Enter your name: Alice
// Expected Output:
// Hello, Alice! Welcome to our messaging app.
Console.Write("Enter your name: ");
var userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}! Welcome to our messaging app.");


// Part 7

// You're organizing a fantasy-themed event and need to print custom badges for the participants.
// Develop a C# program that prompts the user to enter their character's name and class.
// Then, concatenate the name and class, and print the result.
// Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
// Test Data:
// Character's name: Legolas
// Character's class: Archer
// Expected Output:
// Custom Badge: Legolas the Archer
Console.Write("Character's name: ");
var characterName = Console.ReadLine();
Console.Write("Character's class: ");
var characterClass = Console.ReadLine();
Console.WriteLine($"Custom Badge: {characterName} the {characterClass}");


// Part 8

// Picture yourself managing a music playlist and need to display the total duration of a song.
// Write a C# program that calculates and formats the total duration of a song in minutes and seconds.
// Prompt the user to enter the song's duration in seconds.
// Then, calculate the minutes and seconds and display the formatted duration.
// Hint: Use integer division and modulus to separate minutes and seconds, and composite formatting to display them.
// Test Data:
// Enter the song's duration in seconds: 245
// Expected Output:
// Song Duration: 4 minutes 5 seconds
Console.Write("Enter the song's duration in seconds: ");
var songDuration = int.Parse(Console.ReadLine());
var minutes = songDuration / 60;
var seconds = songDuration % 60;
Console.WriteLine($"Song Duration: {minutes} minutes {seconds} seconds");


// Part 9

// Imagine you're developing a recipe app and want to display the serving size.
// Create a C# program that formats and displays the serving size of a recipe.
// Prompt the user to enter the number of servings.
// Then, display the serving size aligned to the right with a width of 5 characters.
// Hint: Use composite formatting with alignment to display the serving size.
// Test Data:
// Enter the number of servings: 8
// Expected Output:
// Serving Size:     8
Console.Write("Enter the number of servings: ");
var servings = int.Parse(Console.ReadLine());
Console.WriteLine($"Serving Size: {servings,5}");


// Part 10

// You're designing a finance application and need to show the current account balance.
// Develop a C# program that formats and displays the account balance.
// Prompt the user to enter the account balance.
// Then, display the balance aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the account balance.
// Test Data:
// Enter the account balance: 1050.75
// Expected Output:
// Account Balance: 1050.75
Console.Write("Enter the account balance: ");
var accountBalance = double.Parse(Console.ReadLine());
Console.WriteLine($"Account Balance: {accountBalance,10:0.00}");



// Part 11

// You're building a movie ticket booking system and need to present the ticket price.
// Write a C# program that calculates and formats the ticket price with discounts.
// Prompt the user to enter the ticket price and discount percentage.
// Then, calculate the discounted price and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the discounted price.
// Test Data:
// Enter the ticket price: 25.50
// Enter the discount percentage: 15
// Expected Output:
// Discounted Price: 21.68
Console.Write("Enter the ticket price: ");
var ticketPrice = double.Parse(Console.ReadLine());
Console.Write("Enter the discount percentage: ");
var discountPercentage = double.Parse(Console.ReadLine());
var discountedPrice = ticketPrice - (ticketPrice * discountPercentage / 100);
Console.WriteLine($"Discounted Price: {discountedPrice,10:0.00}");


// Part 12

// Picture yourself developing a gaming platform and need to display the player's score.
// Create a C# program that formats and displays the player's score.
// Prompt the user to enter the player's score.
// Then, display the score aligned to the right with a width of 8 characters.
// Hint: Use composite formatting with alignment to display the player's score.
// Test Data:
// Enter the player's score: 10325
// Expected Output:
// Player's Score:   10325
Console.Write("Enter the player's score: ");
var playerScore = int.Parse(Console.ReadLine());
Console.WriteLine($"Player's Score: {playerScore,8}");


// Part 13

// You're working on a data analysis tool and need to present the statistical results.
// Develop a C# program that formats and displays the average value of a dataset.
// Prompt the user to enter a series of numbers separated by spaces.
// Then, calculate the average value and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the average value.
// Test Data:
// Enter a series of numbers: 10 15 20 25 30
// Expected Output:
// Average Value: 20.00
Console.Write("Enter a series of numbers: ");
var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
var average = numbers.Average();
Console.WriteLine($"Average Value: {average,10:0.00}");


// Part 14

// Imagine you're designing a weather app and need to show the temperature forecast.
// Write a C# program that calculates and formats the average temperature.
// Prompt the user to enter the temperatures for three days separated by spaces.
// Then, calculate the average temperature and display it aligned to the right with one decimal place.
// Hint: Use composite formatting with alignment and precision to display the average temperature.
// Test Data:
// Enter temperatures for 3 days: 25.5 28.7 22.3
// Expected Output:
// Average Temperature: 25.5
Console.Write("Enter temperatures for 3 days: ");
var temperatures = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
var averageTemperature = temperatures.Average();
Console.WriteLine($"Average Temperature: {averageTemperature,10:0.0}");


// Part 15

// You're building a fitness tracker and need to present the daily step count.
// Create a C# program that formats and displays the total steps for a day.
// Prompt the user to enter the steps taken.
// Then, display the step count aligned to the right with a width of 6 characters.
// Hint: Use composite formatting with alignment to display the step count.
// Test Data:
// Enter the steps taken: 12345
// Expected Output:
// Step Count:  12345
Console.Write("Enter the steps taken: ");
var stepCount = int.Parse(Console.ReadLine());
Console.WriteLine($"Step Count: {stepCount,6}");