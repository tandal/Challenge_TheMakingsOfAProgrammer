//Values for the cards

int estateCardValue= 1;
int duchyCardValue = 3;
int provinceCardValue = 6;

//Ask the user how many of each card they have.
Console.WriteLine("How many Estate cards do you have?");
int totalEstateCards = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many Duchy cards do you have?");
int totalDuchyCards = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many Province cards do you have?");
int totalProvinceCards = Convert.ToInt32(Console.ReadLine());


//Provide the user with how many points they have.
int estatePointCalculated = estateCardValue * totalEstateCards;
int duchyPointCalculated = duchyCardValue * totalDuchyCards;
int provincePointCalculated = provinceCardValue * totalProvinceCards;
int totalPoint = estatePointCalculated + duchyPointCalculated + provincePointCalculated;
Console.WriteLine($"You had {totalEstateCards} Estate card(s) totaling {estatePointCalculated} points.\n" +
    $"You had {totalDuchyCards} Estate card(s) totaling {duchyPointCalculated} points.\n" +
    $"You had {totalProvinceCards} Estate card(s) totaling {provincePointCalculated} points.\n" +
    $"Your grand total is {totalPoint} points!"
);
