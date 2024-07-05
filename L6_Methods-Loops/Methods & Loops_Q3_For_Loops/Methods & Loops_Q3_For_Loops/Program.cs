//Use For Loops to solve the following problems.



//Part 1
//Write a program in C to display the first 10 natural numbers.
//Expected Output:
//1 2 3 4 5 6 7 8 9 10
Console.WriteLine("The first 10 natural numbers are:");
for (int i = 1; i <= 10; i++)
{
    Console.Write(i + " ");
}

//Part 2
//Write a program in C to display the cube of the number up to an integer.
//Expected Output:
//Input number of terms: 5
//Number is: 1 and cube of the 1 is: 1
//Number is: 2 and cube of the 2 is: 8
//Number is: 3 and cube of the 3 is: 27
//Number is: 4 and cube of the 4 is: 64
//Number is: 5 and cube of the 5 is: 125
Console.WriteLine("\nCube of the number up to an integer:");
Console.WriteLine("Input number of terms: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number is: ");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i + " and cube of the " + i + " is: " + (i * i * i));
}

//Part 3
//Write a program in C to display the multiplication table of a given integer.
//Expected Output:
//Input the number (Table to be calculated): 15
//15 X 1 = 15
//...
//15 X 10 = 150
Console.WriteLine("Multiplication table of a given integer:");
Console.WriteLine("Input the number (Table to be calculated): ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(num + " X " + i + " = " + (num * i));
}


//Part 4
//Write a C# Sharp program to display an alphabet pattern like Y with an asterisk.
//Hint: Use nested loop
//Expected Output:
// *     *
//  *   *
//   * *
//    *
//    *
//    *
//    *
Console.WriteLine("Alphabet pattern like Y with an asterisk:");
for (int i = 0; i < 7; i++)
{
    if (i < 4)
    {
        for (int j = 0; j < 7; j++)
        {
            if (j == i || j == 6 - i)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
    else
    {
        Console.Write("   *");
    }
    Console.WriteLine();
}

// Part 5: Character Health Regeneration
// Simulate the regeneration of a game character's health over 5 rounds. Display the character's health after each round, regenerating 10 health points per round.
// Expected Output:
// Round 1: Health 10
// Round 2: Health 20
// ...
// Round 5: Health 50
int health = 0;
for (int i = 1; i <= 5; i++)
{
    health += 10;
    Console.WriteLine("Round " + i + ": Health " + health);
}



/////////// For Each Loop ///////////

//Use For Each Loops to solve the following problems.

//Part 6
// Create an list of names and iterate through each name and display the name.
//Expected Output:
//Name: John
//Name: James
//Name: Luke
//Name: Lila
List<string> names = new List<string> { "John", "James", "Luke", "Lila" };
foreach (string name in names)
{
    Console.WriteLine("Name: " + name);
}

//Part 7
//Create a list of number , iterate through them and display the square of each number.
//Expected Output:
//Square of 2: 4
//Square of 3: 9
//Square of 4: 16
//Square of 5: 25
List<int> numbers = new List<int> { 2, 3, 4, 5 };
foreach (int number in numbers)
{
    Console.WriteLine("Square of " + number + ": " + (number * number));
}