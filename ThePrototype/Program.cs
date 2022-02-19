// Application Title
Console.Title = "The Prototype";

// Allow the pilot to enter in a number
Console.Write("Pilot, please enter in a number in this range 0 - 100: ");
int pilotsNumber = Convert.ToInt32(Console.ReadLine());

// If the number entered is above 100 or less than 0 keep asking
while (pilotsNumber > 100 || pilotsNumber < 0)
{ 
    Console.ForegroundColor = ConsoleColor.Red; // Show the alert in red.
    Console.Write($"Sorry we could not accept {pilotsNumber} as an entry. Please enter in a number within this range 0-100: ");
    Console.ForegroundColor = ConsoleColor.White; // Change the user entry to white.
    pilotsNumber = Convert.ToInt32(Console.ReadLine());
    continue;
}

// Clear the screen once the program has collected a good number
Console.Clear();

// Ask a second user, the hunter, to guess a number
Console.Write("Hunter, please enter in a number in this range 0 - 100: ");
int huntersNumber = Convert.ToInt32(Console.ReadLine());

/* 
 Indicate whether the user guessed too high, too low, or guessed right
 Loop until they get it right, then end the program 
 Increment the amount of guesses it took to solve
*/

int amountOfGuesses = 0;

while (huntersNumber != pilotsNumber)
{
    if (huntersNumber < pilotsNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red; // Show the alert in red.
        Console.Write($"Sorry, {huntersNumber} is to low. Please enter in a bigger number within the 0 - 100 range: ");
        Console.ForegroundColor = ConsoleColor.White; // Change the user entry to white.
        huntersNumber = Convert.ToInt32(Console.ReadLine());
        amountOfGuesses++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red; // Show the alert in red.
        Console.Write($"Sorry, {huntersNumber} is to high. Please enter in a lower number within the 0 - 100 range: ");
        Console.ForegroundColor = ConsoleColor.White; // Change the user entry to white.
        huntersNumber = Convert.ToInt32(Console.ReadLine());
        amountOfGuesses++;
    }
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"You located the pilot at {pilotsNumber}. It took you {amountOfGuesses} tries to locate the pilot.");