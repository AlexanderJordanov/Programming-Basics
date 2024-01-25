int turnsOfGame = int.Parse(Console.ReadLine());
double totalPoints = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
for (int i = 0; i < turnsOfGame; i++)
{
    int pointsPerTurn = int.Parse(Console.ReadLine());

    if (pointsPerTurn >= 0 && pointsPerTurn < 10)
    {
        counter1++;
        totalPoints += 0.2 * pointsPerTurn;
    }
    else if (pointsPerTurn >= 10 && pointsPerTurn < 20)
    {
        counter2++;
        totalPoints += 0.3 * pointsPerTurn;
    } 
    else if (pointsPerTurn >= 20 && pointsPerTurn < 30)
    {
        counter3++;
        totalPoints += 0.4 * pointsPerTurn;
    }
    else if (pointsPerTurn >= 30 && pointsPerTurn < 40)
    {
        counter4++;
        totalPoints += 50;
    }
    else if (pointsPerTurn >= 40 && pointsPerTurn <= 50)
    {
        counter5++;
        totalPoints += 100;
    }
    else
    {
        counter6++;
        totalPoints /= 2;
    }
}

double firstCounterPercentage = 100.0 * counter1 / turnsOfGame;
double secondCounterPercentage = 100.0 * counter2 / turnsOfGame;
double thirdCounterPercentage = 100.0 * counter3 / turnsOfGame;
double fourthCounterPercentage = 100.0 * counter4 / turnsOfGame;
double fifthCounterPercentage = 100.0 * counter5 / turnsOfGame;
double sixthCounterPercentage = 100.0 * counter6 / turnsOfGame;

Console.WriteLine($"{totalPoints:f2}");
Console.WriteLine($"From 0 to 9: {firstCounterPercentage:f2}%");
Console.WriteLine($"From 10 to 19: {secondCounterPercentage:f2}%");
Console.WriteLine($"From 20 to 29: {thirdCounterPercentage:f2}%");
Console.WriteLine($"From 30 to 39: {fourthCounterPercentage:f2}%");
Console.WriteLine($"From 40 to 50: {fifthCounterPercentage:f2}%");
Console.WriteLine($"Invalid numbers: {sixthCounterPercentage:f2}%");

