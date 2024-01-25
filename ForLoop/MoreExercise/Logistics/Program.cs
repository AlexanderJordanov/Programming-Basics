int countOfCargo = int.Parse(Console.ReadLine());
int totalWeight = 0;
int microbusCargo = 0;
int truckCargo = 0;
int trainCargo = 0;
for (int i = 0; i < countOfCargo; i++)
{
    int weightOfCargo = int.Parse(Console.ReadLine());
    totalWeight += weightOfCargo;

    if (weightOfCargo <= 3)
    {
        microbusCargo += weightOfCargo;
    }
    else if (weightOfCargo > 3 && weightOfCargo <= 11)
    {
        truckCargo += weightOfCargo;
    }
    else
    {
        trainCargo += weightOfCargo;
    }
}

double averagePriceOfTotalCargo = (microbusCargo * 200.0 + truckCargo * 175 + trainCargo * 120) / totalWeight;

double percentMicrobusCargo = 100.0 * microbusCargo / totalWeight;
double percentTruckCargo = 100.0 * truckCargo / totalWeight;
double percentTrainCargo = 100.0 * trainCargo / totalWeight;

Console.WriteLine($"{averagePriceOfTotalCargo:f2}");
Console.WriteLine($"{percentMicrobusCargo:f2}%");
Console.WriteLine($"{percentTruckCargo:f2}%");
Console.WriteLine($"{percentTrainCargo:f2}%");

