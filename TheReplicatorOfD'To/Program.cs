/* [X] Make a program that creates an array of length 5.
 * [X] Ask the user for five numbers and put them in the array.
 * [X] Make a second array of length 5.
 * [X] Use a loop to copy the values out of the original array and into the new one.
 * [X] Display the contents of byth arrays one at a time to illustrate that the Replicator of D'To works.
 */
Console.Title = "The Replicator of D'To";

int[] firstArray = new int[5];
int[] secondArray = new int[5];

Console.WriteLine ("Please enter in 5 numbers.");

for (int i = 0; i < 5; i++) {
    Console.Write($"Number {i}: ");
    firstArray [i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < firstArray.Length; i++)
{
    secondArray[i] = firstArray[i];
}

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("First array:  ");
foreach (int firstArrayEntry in firstArray)
{
    Console.Write($"{firstArrayEntry} ");
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("\nSecond array: ");
foreach (int secondArrayEntry in secondArray)
{
    Console.Write($"{secondArrayEntry} ");
}