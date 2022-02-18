//Let user enter the number of chocolate eggs gathered that day
Console.WriteLine("How many chocolate eggs have you gathered today?");
int amountOfEggsGathered = Convert.ToInt32(Console.ReadLine());


//Using / and %, compute how many eggs each sister should get and how many are left over for duckbear
int sisterCount = 4;
int eggsForTheSisters = (amountOfEggsGathered / sisterCount);
int eggsForDuckBear = (amountOfEggsGathered % sisterCount);
Console.WriteLine($"The four sisters get {eggsForTheSisters} egg(s) each, and Duckbear gets the remaining {eggsForDuckBear} egg(s).");