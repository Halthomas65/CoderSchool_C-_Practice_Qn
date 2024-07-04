public class Program
{
    static void Main()
    {
        ////////////////While Loop////////////////

        //Part 1
        //Create a program that uses a while loop to print out the numbers 1 to 10 to the console.
        //Hint: You can use a while loop to print out the numbers 1 to 10 to the console.
        int x = 1;
        Console.WriteLine("Numbers 1 to 10");
        while (x <= 10)
        {
            Console.WriteLine(x);
            x++;
        }


        //Part 2
        //Create a program that uses a while loop to print out the numbers 10 to 1 to the console.
        //Hint: You can use a while loop to print out the numbers 10 to 1 to the console.
        int y = 10;
        Console.WriteLine("Numbers 10 to 1");
        while (y >= 1)
        {
            Console.WriteLine(y);
            y--;
        }


        //Part 3
        //Create a program that uses a while loop to print out the even numbers from 1 to 10 to the console.
        //Hint: You can use a while loop to print out the even numbers from 1 to 10 to the console.
        int z = 1;
        Console.WriteLine("Even Numbers 1 to 10");
        while (z <= 10)
        {
            if (z % 2 == 0)
            {
                Console.WriteLine(z);
            }
            z++;
        }


        //Part 4
        //Create a program that uses a while loop to print out the odd numbers from 1 to 10 to the console.
        //Hint: You can use a while loop to print out the odd numbers from 1 to 10 to the console.
        int a = 1;
        Console.WriteLine("Odd Numbers 1 to 10");
        while (a <= 10)
        {
            if (a % 2 != 0)
            {
                Console.WriteLine(a);
            }
            a++;
        }


        //Part 5
        //Write a C# Sharp program that takes a number as input and print its multiplication table.
        //Hint: You can use a while loop to print out the multiplication table of a number.
        //Test Data:
        //Enter the number: 5
        //Expected Output:
        //5 * 0 = 0
        //5 * 1 = 5
        //5 * 2 = 10
        //5 * 3 = 15
        //....
        //5 * 10 = 50
        Console.WriteLine("Enter the number: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out int num))
        {
            // Conversion failed, handle the error, e.g., by notifying the user
            Console.WriteLine("Please enter a valid integer.");
        }
        else
        {
            // Conversion successful, use 'num'
            int b = 0;
            Console.WriteLine("Multiplication Table of " + num);
            while (b <= 10)
            {
                Console.WriteLine(num + " * " + b + " = " + num * b);
                b++;
            }
        }


        //Part 6
        //Write a C# Sharp program that takes a number as input and print its factorial.
        //Hint: You can use a while loop to calculate the factorial of a number.
        //Test Data:
        //Enter the number: 5
        //Expected Output:
        //The factorial of 5 is: 120
        Console.WriteLine("Enter the number: ");
        string input2 = Console.ReadLine();
        if (!int.TryParse(input2, out int num2))
        {
            // Conversion failed, handle the error, e.g., by notifying the user
            Console.WriteLine("Please enter a valid integer.");
        }
        else
        {
            // Conversion successful, use 'num'
            int c = 1;
            int fact = 1;
            while (c <= num2)
            {
                fact = fact * c;
                c++;
            }
            Console.WriteLine("The factorial of " + num2 + " is: " + fact);
        }


        //Part 7
        //Write a C# Sharp program that takes a number as input and print the series 1+2+3+ ... +n = sum
        //Hint: You can use a while loop to calculate the sum of a series.
        //Test Data:
        //Enter the number: 5
        //Expected Output:
        //1 + 2 + 3 + 4 + 5 = 15
        Console.WriteLine("Enter the number: ");
        string input3 = Console.ReadLine();
        if (!int.TryParse(input3, out int num3))
        {
            // Conversion failed, handle the error, e.g., by notifying the user
            Console.WriteLine("Please enter a valid integer.");
        }
        else
        {
            // Conversion successful, use 'num'
            int d = 1;
            int sum = 0;
            while (d <= num3)
            {
                sum = sum + d;
                d++;
            }
            Console.WriteLine("The sum of the series 1 to " + num3 + " is: " + sum);
        }


        //Part 8
        //Write a program in C# Sharp to display the multiplication table horizontally from 1 to n.
        //Hint: You can use conseol.write to print out the multiplication table horizontally.
        //Test Data:
        //Input upto the table number starting from 1 : 8
        //Expected Output:
        //Multiplication table from 1 to 8
        //1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
        //...
        //1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80
        Console.WriteLine("Input upto the table number starting from 1: ");
        string input4 = Console.ReadLine();
        if (!int.TryParse(input4, out int num4))
        {
            // Conversion failed, handle the error, e.g., by notifying the user
            Console.WriteLine("Please enter a valid integer.");
        }
        else
        {
            // Conversion successful, use 'num'
            int e = 1;
            Console.WriteLine("Multiplication table from 1 to " + num4);
            while (e <= 10)
            {
                int f = 1;
                while (f <= num4)
                {
                    Console.Write(f + "x" + e + " = " + f * e + ", ");
                    f++;
                }
                Console.WriteLine();
                e++;
            }
        }


        //Part 9
        //Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
        //Hint: You can use a while loop to print out the pattern.
        //Test Data:
        //Input number of rows : 3
        //Expected Output:
        //1
        //12
        //123
        Console.WriteLine("Input number of rows: ");
        string input5 = Console.ReadLine();
        if (!int.TryParse(input5, out int num5))
        {
            // Conversion failed, handle the error, e.g., by notifying the user
            Console.WriteLine("Please enter a valid integer.");
        }
        else
        {
            // Conversion successful, use 'num'
            int g = 1;
            while (g <= num5)
            {
                int h = 1;
                while (h <= g)
                {
                    Console.Write(h);
                    h++;
                }
                Console.WriteLine();
                g++;
            }
        }


        //Part 10
        //Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
        //Hint: You can use a while loop to print out the pattern.
        //Test Data:
        //Input number of rows : 3
        //Expected Output:
        //*
        //**
        //***
        Console.WriteLine("Input number of rows: ");
        string input6 = Console.ReadLine();
        if (!int.TryParse(input6, out int num6))
        {
            // Conversion failed, handle the error, e.g., by notifying the user
            Console.WriteLine("Please enter a valid integer.");
        }
        else
        {
            // Conversion successful, use 'num'
            int i = 1;
            while (i <= num6)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }


        //Part 11
        //Write a program in C# Sharp to make such a pattern like a pyramid with numbers increasing by 1.
        //Hint: You can use a while loop to print out the pattern.
        //Test Data:
        //Input number of rows : 5
        //Expected Output:
        //    1
        //   2 3
        //  4 5 6
        // 7 8 9 10
        //11 12 13 14 15
        Console.WriteLine("Input number of rows: ");
        string input7 = Console.ReadLine();
        if (!int.TryParse(input7, out int num7))
        {
            // Conversion failed, handle the error, e.g., by notifying the user
            Console.WriteLine("Please enter a valid integer.");
        }
        else
        {
            // Conversion successful, use 'num'
            int k = 1;
            int l = 1;
            while (k <= num7)
            {
                int m = 1;
                while (m <= num7 - k)
                {
                    Console.Write(" ");
                    m++;
                }
                int n = 1;
                while (n <= k)
                {
                    Console.Write(l + " ");
                    l++;
                    n++;
                }
                Console.WriteLine();
                k++;
            }
        }


        ////////////////Do While Loop////////////////


        //while loop: Condition is checked before the loop body runs.

        //do-while loop: Loop body runs at least once before checking the condition.

        //Example(Uncomment each loop type to see the difference) 


        //While Loop//

        x = 1;
        while (x < 1)
        {
           Console.WriteLine(x);
           x++;
        }



        //Do While Loop//

        x = 1;
        do
        {
           Console.WriteLine(x);
           x++;
        } while (x < 1);

    }
}