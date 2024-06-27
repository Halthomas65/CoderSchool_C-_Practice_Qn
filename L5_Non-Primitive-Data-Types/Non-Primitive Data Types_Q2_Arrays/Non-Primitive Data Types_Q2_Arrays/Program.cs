
//**Arrays unlike lists have a fixed size and cannot be changed once they are created.**//


//---------------------------------------------------------------------
// Part 1: Printing Array Elements
// Create an array of 5 countries and then print them out to the console.
// Hint: Use a foreach loop to print the array elements.
string[] contries = ["Vietnam", "Singapore", "Malaysia", "Thailand", "Lao"];
Console.WriteLine("List of countries:");
foreach (string country in contries)
{
    Console.WriteLine(country);
}

//---------------------------------------------------------------------
// Part 2: Accessing Array Elements by Index
// Using the array of countries, find the name in the 3rd position and print it out to the console.
// Hint: Use the index of the array to access the name in the 3rd position.
Console.WriteLine("\nThe name in the 3rd position is: " + contries[2]);

//---------------------------------------------------------------------
// Part 3: Removing an Element from the Array
// Using the array of countries, remove the name in the 2nd position and then print the array out to the console.
// Hint: Use the RemoveAt() method to remove an item from the array.
var countryList = contries.ToList();
countryList.RemoveAt(1);
contries = countryList.ToArray();

Console.WriteLine("\nList of countries after removing the name in the 2nd position:");
foreach (string country in contries)
{
    Console.WriteLine(country);
}

//---------------------------------------------------------------------
// Part 4: Replacing an Element in the Array
// Using the array of countries, replace the name in the 3rd position with a new name and then print the array out to the console.
// Hint: Use the index of the array to replace the name in the 3rd position with a new name.
contries[2] = "Indonesia";
Console.WriteLine("\nList of countries after replacing the name in the 3rd position:");
foreach (string country in contries)
{
    Console.WriteLine(country);
}

//---------------------------------------------------------------------
// Part 5: Finding the Length of the Array
// Using the array of countries, find the length of the array and print it out to the console.
// Hint: Use the Length property to find the length of the array.
Console.WriteLine("\nThe length of the array is: " + contries.Length);

//---------------------------------------------------------------------
// Part 6: Checking if an Element Exists in the Array
// Using the array of countries, check if a name exists in the array and print out if it exists or not.
// Hint: Use the Contains() method to check if a name exists in the array.
string searchCountry = "Thailand";
if (contries.Contains(searchCountry))
{
    Console.WriteLine("\nThe country " + searchCountry + " exists in the array.");
}
else
{
    Console.WriteLine("\nThe country " + searchCountry + " does not exist in the array.");
}

//---------------------------------------------------------------------
// Part 7: Finding the Index of an Element in the Array
// Using the array of countries, find the index of a name in the array and print it out to the console.
// Hint: Use the IndexOf() method to find the index of a name in the array.
string findCountry = "Indonesia";
int index = Array.IndexOf(contries, findCountry);
Console.WriteLine("\nThe index of the country " + findCountry + " is: " + index);
