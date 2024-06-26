//Part 1
//Create a list of 5 names and then print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.
List<string> names = new List<string>() { "John", "Jane", "Jack", "Jill" };
names.Add("James");
Console.WriteLine("List of names:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Part 2
//Using the list of names and find the name in the 3rd position and print it out to the console.
//Hint: You can use the index of the list to find the name in the 3rd position.
Console.WriteLine("\nThe name in the 3rd position is: " + names[2]);

//Part 3
//Using the list of names, remove the name in the 2nd position and then print the list out to the console.
//Hint: You can use the RemoveAt() method to remove an item from the list.
names.RemoveAt(1);
Console.WriteLine("\nList of names after removing the name in the 2nd position:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Part 4
//Using the list of names, add a new name to the list and then print the list out to the console.
//Hint: You can use the Add() method to add a new name to the list.
names.Add("Jenny");
Console.WriteLine("\nList of names after adding a new name:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Part 5
//Using the list of names , find the length of the list and print it out to the console.
//Hint: You can use the Count property to find the length of the list.
Console.WriteLine("\nThe length of the list is: " + names.Count);

//Part 6
//Using the list of names , check if a name exists in the list and print out if it exists or not.
//Hint: You can use the Contains() method to check if a name exists in the list.
string searchName = "Jack";
if (names.Contains(searchName))
{
    Console.WriteLine("\nThe name " + searchName + " exists in the list.");
}
else
{
    Console.WriteLine("\nThe name " + searchName + " does not exist in the list.");
}

//Part 7
//Using the list of names, find the index of a name in the list and print it out to the console.
//Hint: You can use the IndexOf() method to find the index of a name in the list.
string findName = "Jenny";
int index = names.IndexOf(findName);
Console.WriteLine("\nThe index of the name " + findName + " is: " + index);

//Part 8
//Using the list of names, insert a new name at the 3rd position and print the list out to the console.
//Hint: You can use the Insert() method to insert a new name at a specific position in the list.
names.Insert(2, "Jessica");
Console.WriteLine("\nList of names after inserting a new name at the 3rd position:");

//Part 9
//Using the list of names, sort the list and print it out to the console.
//Hint: You can use the Sort() method to sort the list.
names.Sort();
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Part 10
//Using the list of names , use findlastindex() method to find the last index of a name in the list and print it out to the console.
//Hint: You can use the FindLastIndex() method to find the last index of a name in the list.
string findLastName = "Jessica";
int lastIndex = names.FindLastIndex(x => x == findLastName);
Console.WriteLine("\nThe last index of the name " + findLastName + " is: " + lastIndex);

//Part 11
//Using the list of names, clear the list and print the list out to the console.
//Hint: You can use the Clear() method to clear the list.
names.Clear();
Console.WriteLine("\nList of names after clearing the list:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Part 12
//Create a new list of strings and integers and print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.

List<object> namesAndAges = new List<object>() { "John", 10, "Jane", 12, "Jack", 42, "Jill", 14 };
// List<string> namesAndAges = new List<string>() { "John", "Jane", "Jack", "Jill" };
// List<int> ages = new List<int>() { 25, 30, 35, 40 };
Console.WriteLine("\nList of names and ages:");
for (int i = 0; i < namesAndAges.Count; i++)
{
    // Console.WriteLine(namesAndAges[i] + " - " + ages[i]);
    Console.WriteLine(namesAndAges[i]);
}

