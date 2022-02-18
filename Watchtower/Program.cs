// Application Title

Console.Title = "Watchtower";

// Ask the user for an x and y value
Console.WriteLine("Help the watchtowers locate the enemy!");

Console.Write("\nPlease enter in a value for x: ");
int xEnteredValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter in a value for y: ");
int yEnteredValue = Convert.ToInt32(Console.ReadLine());

// Inform the user where the enemy is located

if (xEnteredValue < 0 && yEnteredValue > 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("The enemy is to the northwest!");
}
else if (xEnteredValue == 0 && yEnteredValue > 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("The enemy is to the north!");
}
else if (xEnteredValue > 0 && yEnteredValue > 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("The enemy is to the northeast!");
}
else if (xEnteredValue < 0 && yEnteredValue == 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("The enemy is to the west!");
}
else if (xEnteredValue == 0 && yEnteredValue == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The enemy is here!");
    Console.Beep();
    Console.Beep();
}
else if (xEnteredValue > 0 && yEnteredValue == 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("The enemy is to the east!");
}
else if (xEnteredValue < 0 && yEnteredValue < 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("The enemy is to the southwest!");
}
else if (xEnteredValue == 0 && yEnteredValue < 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("The enemy is to the south!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("The enemy is to the southeast!");
}

// Keep application open for user to review
Console.ForegroundColor = ConsoleColor.White;
Console.Write("\nPress any key to close. ");
Console.ReadKey();