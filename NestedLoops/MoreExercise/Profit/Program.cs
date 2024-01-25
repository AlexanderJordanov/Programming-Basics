int oneLevCoins = int.Parse(Console.ReadLine());
int twoLevCoins  = int.Parse(Console.ReadLine());
int fiveLevBills = int.Parse(Console.ReadLine());
int sumToCollect = int.Parse(Console.ReadLine());
int actualSum = 0;

for (int i = 0; i <= oneLevCoins; i++)
{
    for (int j = 0; j <= twoLevCoins; j++)
    {
        for (int k = 0; k <= fiveLevBills; k++)
        {
            actualSum = i * 1 + j * 2 + k * 5;

            if (actualSum == sumToCollect)
            {
                Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {actualSum} lv.");
            }
        }
    }
}
