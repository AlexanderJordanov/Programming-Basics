double inheritedMoney = double.Parse(Console.ReadLine());
int yearToLiveTo = int.Parse(Console.ReadLine());
int currentYears = 18;
for (int i = 1800; i <= yearToLiveTo; i++)
{
    if (i % 2 == 0) { inheritedMoney -= 12000; }
    else
    { if (currentYears == 18)
        {
            inheritedMoney -= 12000;
        }
        else if (currentYears > 18)
        {
            inheritedMoney -= 12000 + currentYears * 50;
            } 
    }
    currentYears++;
}
if (inheritedMoney >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
}