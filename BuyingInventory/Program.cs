// Application Title
Console.Title = "Buying Inventory";

// Build a program that will show the menu illustrated above
Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

//Ask the user to enter a number from the menu
Console.Write("What number do you want to see the price of? ");
int usersChoice = Convert.ToInt32(Console.ReadLine());

//Using the information above, use a switch (either type) to show the item's cost.
string response;

response = usersChoice switch
{
    1 => "Rope: 10 gold",
    2 => "Torches: 15 gold",
    3 => "Climbing Equipment: 25 gold",
    4 => "Clean Water: 1 gold",
    5 => "Machete: 20 gold",
    6 => "Canoe: 200 gold",
    7 => "Food Supplies: 1 gold.",
    _ => "We do not carry an item under that number. Please make a selection that is in our list."
};

if (usersChoice < 8)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(response);
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(response);
}

// Keep application open for user to review
Console.ForegroundColor = ConsoleColor.White;
Console.Write("\nPress any key to close. ");
Console.ReadKey();