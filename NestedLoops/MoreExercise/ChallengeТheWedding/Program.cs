int male = int.Parse(Console.ReadLine());
int female  = int.Parse(Console.ReadLine());
int tables = int.Parse(Console.ReadLine());
int tablesCount = 0;

for (int m = 1; m <= male; m++)
{
   for (int f = 1; f <= female; f++)
    {
        Console.Write($"({m} <-> {f}) ");
        tablesCount++;
        if (tablesCount == tables)
        {
            return;
        }
    }
}
