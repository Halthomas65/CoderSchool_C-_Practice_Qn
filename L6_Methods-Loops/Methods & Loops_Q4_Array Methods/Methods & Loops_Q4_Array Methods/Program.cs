﻿// ---------------------------------------------------------------------
// Question: Finding the First Element Meeting a Condition in an Array
// Write a C# program to find and display the first element greater than 50 in an integer array.
// Hint: Use the Array.Find() method with a condition-checking function (Predicate) to find the first element greater than 50 in the array.
// Define a condition-checking function that returns true if the element is greater than 50.
int [] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int result = Array.Find(numbers, element => element > 50);
Console.WriteLine("The first element greater than 50 is: " + result);

// ---------------------------------------------------------------------
// Question: Find the First Element Greater Than 10
// Write a C# program that finds the first element greater than 10 in an integer array and displays it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first element greater than 10.
// Define a condition-checking function that returns true if the element is greater than 10.
numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
result = Array.Find(numbers, element => element > 10);
Console.WriteLine("The first element greater than 10 is: " + result);


//---------------------------------------------------------------------
// Question: Find the First Negative Number
// Write a C# program to find the first negative number in an array of integers and display it.
// Hint: Define an array of integers. Use Array.Find() method with a condition-checking function to find the first negative number.
// Define a condition-checking function that returns true if the element is negative.
numbers = new int[] { 1, 2, 3, 4, -5, 6, 7, 8, -9, 10, -11, 12, 13, 14, 15 };
result = Array.Find(numbers, element => element < 0);
Console.WriteLine("The first negative number is: " + result);