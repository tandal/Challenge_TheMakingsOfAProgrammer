// Add application title
Console.Title = "Repairing the Great Clocktower of Consolas";

// Take a number as input from the console
Console.Write("Please provide the great Clocktower of Consolas a number: ");
int entryNumber = Convert.ToInt32(Console.ReadLine());

// Display the word "Tick" if the number is even. Display the word "Tock" if the number is odd.
if (entryNumber % 2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nYou have entered an even number, the great Clocktower of Consolas responds with 'Tick'");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nYou have entered an odd number, the great Clocktower of Consolas responds with 'Tock'");
}

// Keep application open for user to review
Console.ForegroundColor= ConsoleColor.White;
Console.Write("\nPress any key to close. ");
Console.ReadKey();  