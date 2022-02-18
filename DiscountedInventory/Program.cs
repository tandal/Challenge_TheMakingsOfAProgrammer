
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

//Ask the user to enter their name
Console.Write("What is your first name? ");
string usersName = Console.ReadLine();

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

//Discounted list
string discountResponse;

discountResponse = usersChoice switch
{
    1 => "Rope: 5 gold",
    2 => "Torches: 7 gold",
    3 => "Climbing Equipment: 13 gold",
    4 => "Clean Water: Free",
    5 => "Machete: 10 gold",
    6 => "Canoe: 100 gold",
    7 => "Food Supplies: Free",
    _ => "We do not carry an item under that number. Please make a selection that is in our list."
};

/* 
 * If the entered name equals the shop owners name alert the user they get 50% off their purchase, and provide them with the discounted list.
 * If the entered name does not equal provide the user with the standard rates.
 * If an item is selected that isn't in the list inform the user.
 */

string shopOwnersName = "Tortuga";

if (usersChoice < 8 && usersName == shopOwnersName)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Beep();
    Console.Beep();
    Console.WriteLine("Since we have the same name you get 50% off all the items in the shop!");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(discountResponse);
}
else if (usersChoice < 8)
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