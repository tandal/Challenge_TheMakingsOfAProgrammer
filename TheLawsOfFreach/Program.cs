// [X] Start with the code from computing an array's minimum and average values in the section Some Examples with Arrays, starting on page 90.
// [X] Modify the code to use foreach loops instaead of for loops.
Console.Title = "The Laws Of Freach";

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentMinimum = int.MaxValue; // Start higher than anything in the array. 

foreach (int value in array)
{
    if (value < currentMinimum)
        currentMinimum = value;
}

Console.Write($"The smallest number in the array is ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(currentMinimum);
Console.ForegroundColor = ConsoleColor.White;

int total = 0;

foreach (int value in array)
    total += value;

float average = (float)total / array.Length;

Console.Write($"\nThe average of the array is ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(average);