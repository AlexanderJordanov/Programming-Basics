int months = int.Parse(Console.ReadLine());
double totalElectricityPrice = 0;
double totalWaterPrice = 0;
double totalInternetPrice = 0;
double totalOtherPrices = 0;
for (int i = 0; i < months; i++)
{
    double electricityPerMonth = double.Parse(Console.ReadLine());
    totalElectricityPrice += electricityPerMonth;

    totalWaterPrice += 20;
    totalInternetPrice += 15;

    double otherPricePerMonth = (15 + 20 + electricityPerMonth) + (15 + 20 + electricityPerMonth) * 0.2;

    totalOtherPrices += otherPricePerMonth;
}
double averagePerMonth = (totalElectricityPrice + totalWaterPrice + totalInternetPrice + totalOtherPrices) / months;
//•	5ти ред: "Average: {средно всички разходи за месец} lv"

Console.WriteLine($"Electricity: {totalElectricityPrice:f2} lv");
Console.WriteLine($"Water: {totalWaterPrice:f2} lv");
Console.WriteLine($"Internet: {totalInternetPrice:f2} lv");
Console.WriteLine($"Other: {totalOtherPrices:f2} lv");
Console.WriteLine($"Average: {averagePerMonth:f2} lv");

