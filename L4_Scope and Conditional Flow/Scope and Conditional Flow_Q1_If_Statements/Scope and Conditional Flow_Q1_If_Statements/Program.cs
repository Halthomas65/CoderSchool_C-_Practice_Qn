﻿// This input is for part 1 to 6
Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//Part 1
// Get two inputs from the users and store them in two variables and use and if statement to check if the two inputs are equal and print out a message to the console.
// Hint: You can use the == operator to check if two values are equal.
Console.WriteLine("The two numbers are equal: " + (num1 == num2));


//Part 2
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than the second input and print out a message to the console.
// Hint: You can use the > operator to check if the first input is greater than the second input.
Console.WriteLine("The first number is greater than the second number: " + (num1 > num2));

//Part 3
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than the second input and print out a message to the console.
// Hint: You can use the < operator to check if the first input is less than the second input.
Console.WriteLine("The first number is less than the second number: " + (num1 < num2));

//Part 4
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is not equal to the second input and print out a message to the console.
// Hint: You can use the != operator to check if two values are not equal.
Console.WriteLine("The two numbers are not equal: " + (num1 != num2));

//Part 5
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is greater than or equal to the second input and print out a message to the console.
// Hint: You can use the >= operator to check if the first input is greater than or equal to the second input.
Console.WriteLine("The first number is greater than or equal to the second number: " + (num1 >= num2));

//Part 6
// Get two inputs from the user and store them in two variables and use an if statement to check if the first input is less than or equal to the second input and print out a message to the console.
// Hint: You can use the <= operator to check if the first input is less than or equal to the second input.
Console.WriteLine("The first number is less than or equal to the second number: " + (num1 <= num2));

//Part 7
// Create a math quiz that asks the user a math question and checks if the user's answer is correct. If the user's answer is correct, print out a message to the console. If the user's answer is incorrect, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user's answer is correct.
Console.WriteLine("What is 2 + 2? ");
int answer = Convert.ToInt32(Console.ReadLine());
if (answer == 4)
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect!");
}

//Part 8
// Create a program that asks the user for their age and checks if the user is old enough to vote. If the user is old enough to vote, print out a message to the console. If the user is not old enough to vote, print out a different message to the console.
// Hint: You can use the Console.ReadLine() method to get input from the user and use an if statement to check if the user is old enough to vote.
Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
const int votingAge = 18;
if (age >= votingAge)
{
    Console.WriteLine("You are old enough to vote!");
}
else
{
    Console.WriteLine("You are not old enough to vote!");
}


//Part 9
// Create a program that check which state a enemy is in based on their health points. 
// If the enemy has 100 health points, print out a message to the console. 
// If the enemy has 50 health points, print out a different message to the console. 
// If the enemy has 25 health points, print out a different message to the console. 
// If the enemy has 0 health points, print out a different message to the console.
// Hint: You can use an if-else statement to check the enemy's health points and print out a message based on the enemy's health points.
Console.WriteLine("Enter enemy's health points: ");
int enemyHP = Convert.ToInt32(Console.ReadLine());
if (enemyHP == 100)
{
    Console.WriteLine("Enemy is at full health!");
}
else if (enemyHP == 50)
{
    Console.WriteLine("Enemy is at half health!");
}
else if (enemyHP == 25)
{
    Console.WriteLine("Enemy is at low health!");
}
else if (enemyHP == 0)
{
    Console.WriteLine("Enemy is defeated!");
}
else
{
    Console.WriteLine("Enemy is at " + enemyHP + " health points.");
}

//Part 10
// Create a program that checks if a user is eligible for a discount based on their age. If the user is 18 years old or older, print out a message to the console. If the user is younger than 18 years old, print out a different message to the console.
// Hint: You can use an if-else statement to check the user's age and print out a message based on the user's age.
Console.WriteLine("Enter your age: "); 
int userAge = Convert.ToInt32(Console.ReadLine());
if (userAge >= 18)
{
    Console.WriteLine("You are eligible for a discount!");
}
else
{
    Console.WriteLine("You are not eligible for a discount.");
}




////////////// Break , Continue Statements //////////////
Console.WriteLine("\n////////////// Break , Continue Statements //////////////\n");


//Part 1
// Create a program that counts from 1 to 20, but skips counting the number 5.
// Hint: Use a for loop to iterate through the numbers and a continue statement to skip the number 5.
Console.WriteLine("Counting from 1 to 20, but skipping the number 5:");
for (int i = 1; i <= 20; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}

//Part 2
// Create a program that prints the numbers from 1 to 10, but breaks the loop if the number 7 is encountered.
// Hint: Use a for loop to iterate through the numbers and a break statement to exit the loop when 7 is encountered.
Console.WriteLine("Printing numbers from 1 to 10, but breaking the loop if the number 7 is encountered:");
for (int i = 1; i <= 10; i++)
{
    if (i == 7)
    {
        break;
    }
    Console.WriteLine(i);
}

//Part 3
// Write a program to print all even numbers from 1 to 20, but skip printing the number 10.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 10.
Console.WriteLine("Printing even numbers from 1 to 20, but skipping the number 10:");
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        if (i == 10)
        {
            continue;
        }
        Console.WriteLine(i);
    }
}

//Part 4
// Create a program that searches for the word "apple" in a list of fruits. If found, print "Apple found!"; otherwise, continue searching.
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement to check if the current fruit is "apple". Use a continue statement to continue searching if "apple" is not found.
string[] fruits = { "banana", "orange", "apple", "grapes", "mango" };
foreach (string fruit in fruits)
{
    if (fruit == "apple")
    {
        Console.WriteLine("Apple found!");
        break;
    }
    else
    {
        continue;
    }
}

//Part 5
// Write a program to count from 1 to 100, but skip counting by 10s.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip counting by 10s.
Console.WriteLine("Counting from 1 to 100, but skipping by 10s:");
for (int i = 1; i <= 100; i++)
{
    if (i % 10 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}

//Part 6
// Create a program to print the letters of the alphabet from A to G, but skip printing the letter 'E'.
// Hint: Use a for loop to iterate through the alphabet and an if statement with a continue statement to skip printing 'E'.
Console.WriteLine("Printing the letters of the alphabet from A to G, but skipping the letter 'E':");
for (char letter = 'A'; letter <= 'G'; letter++)
{
    if (letter == 'E')
    {
        continue;
    }
    Console.WriteLine(letter);
}

//Part 7
// Write a program to find and print all prime numbers between 1 and 50, skipping non-prime numbers.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip non-prime numbers.
Console.WriteLine("Prime numbers between 1 and 50:");
for (int i = 1; i <= 50; i++)
{
    if (i == 1)
    {
        continue;
    }
    bool isPrime = true;
    for (int j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine(i);
    }
}

//Part 8
// Create a program to print the numbers from 1 to 10, but skip printing the number 3.
// Hint: Use a for loop to iterate through the numbers and an if statement with a continue statement to skip printing 3.
Console.WriteLine("Printing numbers from 1 to 10, but skipping the number 3:");
for (int i = 1; i <= 10; i++)
{
    if (i == 3)
    {
        continue;
    }
    Console.WriteLine(i);
}

//Part 9
// Write a program to search for the number 20 in an array of integers. If found, print its index; otherwise, continue searching.
// Hint: Use a for loop to iterate through the array and an if statement to check if the current element is 20. Use a continue statement to continue searching if 20 is not found.
int[] numbers = { 10, 15, 20, 25, 30 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 20)
    {
        Console.WriteLine("Number 20 found at index: " + i);
        break;
    }
    else
    {
        continue;
    }
}

//Part 10
// Create a program that prints the names of different fruits, but skips printing the name "banana".
// Hint: Use a foreach loop to iterate through the list of fruits and an if statement with a continue statement to skip printing "banana".
// fruits = { "apple", "banana", "orange", "grapes", "mango" };
foreach (string fruit in fruits)
{
    if (fruit == "banana")
    {
        continue;
    }
    Console.WriteLine(fruit);
}



////////////// Extra Challenges //////////////
Console.WriteLine("\n////////////// Extra Challenges //////////////\n");

/*
Part 11

ABC Company pays its sales agents on a commission basis. 
Each agent is paid 10% commission for monthly sales above or equal to $10,000 and 5% commission for monthly sales below $10,000.

Write a program to accept the monthly sales of a particular agent and based on the amount, determine and print out the commission earned.

Example:
Enter the monthly sales: 12000
Commission earned: $1200.00

*/
Console.Write("Enter the monthly sales: ");
double sale = Convert.ToDouble(Console.ReadLine());
double commission = 0;
if (sale >= 10000)
{
    commission = sale * 0.10;
}
else
{
    commission = sale * 0.05;
}
Console.WriteLine("Commission earned: $" + commission);


/*
Part 12

Write a program that generates two integers between 0 and 100 inclusive and prompts the user to enter the sum of these 2 integers. The program reports if the answer is correct or wrong (program will also print the correct answer if the user's answer is wrong).

Hint: You need to use the random module.

Example:
Enter the sum of 43 and 58: 100
Correct!
 */
num1 = new Random().Next(0, 101);
num2 = new Random().Next(0, 101);
Console.Write("Enter the sum of " + num1 + " and " + num2 + ": ");
int sum = Convert.ToInt32(Console.ReadLine());
if (sum == num1 + num2)
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Wrong! The correct answer is " + (num1 + num2));
}



/*
 Part 13

The grade that you get for a module depends on your marks. The table below shows the grade for each range of marks.

Marks   |   Grade   |   Comment
---------------------------------
>= 85   |     A+    |  Excellent!
>= 80   |     A     |  Well done.
>= 75   |     B+    |
>= 70   |     B     |
>= 65   |     C+    |
>= 60   |     C     |
>= 55   |     D+    |
>= 50   |     D     |
< 50    |     F     |  See me.

Write a program that asks for a student’s marks, then displays the correct grade and the corresponding comment (if any).

Example:
Enter student's marks: 82
Grade: A
Comment: Well done.
*/
Console.Write("Enter student's marks: ");
int marks = Convert.ToInt32(Console.ReadLine());
string grade = "";
string comment = "";
if (marks >= 85)
{
    grade = "A+";
    comment = "Excellent!";
}
else if (marks >= 80)
{
    grade = "A";
    comment = "Well done.";
}
else if (marks >= 75)
{
    grade = "B+";
}
else if (marks >= 70)
{
    grade = "B";
}
else if (marks >= 65)
{
    grade = "C+";
}
else if (marks >= 60)
{
    grade = "C";
}
else if (marks >= 55)
{
    grade = "D+";
}
else if (marks >= 50)
{
    grade = "D";
}
else
{
    grade = "F";
    comment = "See me.";
}
Console.WriteLine("Grade: " + grade);
if (comment != "")
{
    Console.WriteLine("Comment: " + comment);
}





/*
 Part 14

 A guard in a computer game acts as follows:

If sees_player == False, he will wait

If sees_player == True:
    - If dist_from_player <= 1, he will attack
    - If 2 <= dist_from_player <= 4, he will advance
    - If dist_from_player >= 5, he will wait

Write a program that shows how the guard will act.

Example:
sees_player = True
dist_from_player = 3

The guard will advance.

 
 
 */
bool sees_player = true;
int dist_from_player = 3;
if (sees_player)
{
    if (dist_from_player <= 1)
    {
        Console.WriteLine("The guard will attack.");
    }
    else if (dist_from_player >= 2 && dist_from_player <= 4)
    {
        Console.WriteLine("The guard will advance.");
    }
    else
    {
        Console.WriteLine("The guard will wait.");
    }
}
else
{
    Console.WriteLine("The guard will wait.");
}
