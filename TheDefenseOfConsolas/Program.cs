//Change the window title to be "Defense of Consolas"
Console.Title = "Defense of Consolas";

//Ask the user for the target row and column
Console.Write("Enter target row: ");
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter target column: ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nThe Manticore airship is located at ({targetRow}, {targetColumn})");

//Compute the neighboring rows and columns of where to deploy the squad.
int topCrewMemberRowCalculated = targetRow + 1;
int leftCrewMemberColumnCalculated = targetColumn - 1;
int bottomCrewMemberRowCalculated = targetRow - 1;
int rightCrewMemberColumnCalculated = targetColumn + 1;

string topCrewCoordinates = $"({topCrewMemberRowCalculated}, {targetColumn})";
string leftCrewCoordinates = $"({targetRow}, {leftCrewMemberColumnCalculated})";
string bottomCrewCoordinates = $"({bottomCrewMemberRowCalculated}, {targetColumn})";
string rightCrewCoordinates = $"({targetRow}, {rightCrewMemberColumnCalculated})";

//Display the deployment instructions in a different color of your choosing.
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nThe crew will be deployed to surround the enemy in the following locations:");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nTop Crew: {topCrewCoordinates}");
Console.WriteLine($"Left Crew: {leftCrewCoordinates}");
Console.WriteLine($"Bottom Crew: {bottomCrewCoordinates}");
Console.WriteLine($"Right Crew: {rightCrewCoordinates}");

//Play a sound with Console.Beep when the results have been computed and displayed.
Console.Beep();

//Keep the application and let the user close after reading the results.
Console.ForegroundColor = ConsoleColor.White;
Console.Write("\nPress any key to close.");
Console.ReadKey();