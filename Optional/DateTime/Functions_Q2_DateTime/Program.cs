int days;
int months;
int years;

//Part 1
//Write a C# program to add and subtract days from the date.
//Test Data:
//Enter the date: 12/10/2020
//Enter the number of days to add or subtract: 5
//Expected Output:
//Date after 5 days: 17/10/2020
//Date before 5 days: 07/10/2020
Console.WriteLine("Part 1");
Console.Write("Enter the date (dd/mm/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
Console.Write("Enter the number of days to add or subtract: ");
days = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Date after {days} days: {date.AddDays(days).ToString("d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture)}");
Console.WriteLine($"Date before {days} days: {date.AddDays(-days).ToString("d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture)}");


//Part 2
//Write a C# program to take input from the user and calculate the age of the user.
//Test Data:
//Enter your date of birth: 12/10/1990
//Expected Output:
//You are 30 years, 1 months, 21 days old
Console.WriteLine("\nPart 2");
Console.Write("Enter your date of birth (dd/mm/yyyy): ");
DateTime dob = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
DateTime now = DateTime.Now;
years = now.Year - dob.Year;
months = now.Month - dob.Month;
days = now.Day - dob.Day;
if (days < 0)
{
    months--;
    days += DateTime.DaysInMonth(now.Year, now.Month);
}
if (months < 0)
{
    years--;
    months += 12;
}
Console.WriteLine($"You are {years} years, {months} months, {days} days old");


//Part 3
//Write a C# program to take input from the user and calculate the difference between two dates.
//Test Data:
//Enter the first date: 12/10/2020
//Enter the second date: 16/10/2020
//Expected Output:
//The difference between two dates is: 4 days
Console.WriteLine("\nPart 3");
Console.Write("Enter the first date (dd/mm/yyyy): ");
DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
Console.Write("Enter the second date (dd/mm/yyyy): ");
DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
Console.WriteLine($"The difference between two dates is: {(date2 - date1).Days} days");


//Part 4
//Write a C# program to take the input (days) from the user and Convert days into years, weeks and days.
//Test Data:
//Enter the number of days: 1329
//Expected Output:
//Years: 3
//Weeks: 33
//Days: 3
Console.WriteLine("\nPart 4");
Console.Write("Enter the number of days: ");
int totalDays = Convert.ToInt32(Console.ReadLine());
years = totalDays / 365;
int weeks = (totalDays % 365) / 7;
days = (totalDays % 365) % 7;
Console.WriteLine($"Years: {years}\nWeeks: {weeks}\nDays: {days}");


//Part 5
//Write a C# program to take the input from the user and print day name of week.
//Test Data:
//Enter the number of day: 4
//Expected Output:
//Thursday
Console.WriteLine("\nPart 5");
Console.Write("Enter the number of day: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(((DayOfWeek)day).ToString());


//Part 6
//Write a C# Sharp program to retrieve the current date.
//Expected Output:
//The current date is: 12/10/2020
Console.WriteLine("\nPart 6");
Console.WriteLine($"The current date is: {DateTime.Now.ToString("dd/MM/yyyy")}");


//Part 7
//Write a C# program to retrieve the current date and time.
//Expected Output:
//The current date and time is: 12/10/2020 10:30:50
Console.WriteLine("\nPart 7");
Console.WriteLine($"The current date and time is: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");