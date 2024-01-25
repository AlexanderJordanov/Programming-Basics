int minSum = int.MaxValue;
int maxSum = int.MinValue;
int maxDiff = 0;
int pairs = int.Parse(Console.ReadLine());
for (int i = 0; i < pairs; i++)
{
    int currentNumber1 = int.Parse(Console.ReadLine());
    int currentNumber2 = int.Parse(Console.ReadLine());
    int currentSum = currentNumber1 + currentNumber2;
    if (currentSum > maxSum)
    {
        maxSum = currentSum;
    }
    if (currentSum < minSum)
    {
        minSum = currentSum;
    }
    maxDiff = maxSum - minSum;
}
if (minSum == maxSum)
{
    Console.WriteLine($"Yes, value={minSum}");
}
if (minSum != maxSum && pairs != 0)
{
    Console.WriteLine($"No, maxdiff={maxDiff}");
}