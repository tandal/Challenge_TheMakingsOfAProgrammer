/*
[X] Loop through 1 and 100 and display what kind of blast the crew should expect (Every 3rd crank = Red, Every 5th crank = Yellow, When Red and Yellow meet it = Blue)
[X] Change the color of the output based on the type of blast (red for Fire, yellow for Electric, and blue for Electric and Fire)
*/

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}:Potent");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}:Electric");
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}:Fire");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{i}:Normal");
    }
}