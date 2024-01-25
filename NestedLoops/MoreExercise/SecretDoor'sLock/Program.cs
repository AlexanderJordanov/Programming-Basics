int hundredsMax = int.Parse(Console.ReadLine());
int tensMax = int.Parse(Console.ReadLine());
int unitsMax = int.Parse(Console.ReadLine());

for (int hundredsNumber = 2; hundredsNumber <= hundredsMax; hundredsNumber++)
{
    for (int tensNumber = 2; tensNumber <= tensMax; tensNumber++)
    { 
        for (int unitsNumber = 2; unitsNumber <= unitsMax; unitsNumber++)
        {
            if (hundredsNumber % 2 == 0)
            {
                if (tensNumber == 2 || tensNumber == 3 || tensNumber == 5 || tensNumber == 7)
                {
                    if (unitsNumber %  2 == 0)
                    {
                        Console.WriteLine($"{hundredsNumber} {tensNumber} {unitsNumber}");
                    }
                }
            }
        } 
    }
}
