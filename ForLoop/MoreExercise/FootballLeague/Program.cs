int stadiumCapacity = int.Parse(Console.ReadLine());
int amountOfFans  = int.Parse(Console.ReadLine());  
int sectorA = 0, sectorB = 0, sectorV = 0, sectorG = 0;
for  (int i = 0; i < amountOfFans; i++)
{
    string sector = Console.ReadLine();

    if (sector == "A")
    {
        sectorA++;
    }
    else if (sector == "B")
    {
        sectorB++;
    }
    else if (sector == "V")
    {
        sectorV++;
    }
    else if (sector == "G")
    {
        sectorG++;
    }
}
double percentSectorA = 100.0 * sectorA / amountOfFans;
double percentSectorB = 100.0 * sectorB / amountOfFans;
double percentSectorV = 100.0 * sectorV / amountOfFans;
double percentSectorG = 100.0 * sectorG / amountOfFans;
double percentOfStadium = 100.0 * amountOfFans / stadiumCapacity;

Console.WriteLine($"{percentSectorA:f2}%");
Console.WriteLine($"{percentSectorB:f2}%");
Console.WriteLine($"{percentSectorV:f2}%");
Console.WriteLine($"{percentSectorG:f2}%");
Console.WriteLine($"{percentOfStadium:f2}%");
