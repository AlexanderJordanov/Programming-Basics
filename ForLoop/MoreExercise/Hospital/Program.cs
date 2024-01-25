int days = int.Parse(Console.ReadLine());
int doctors = 7;
int treatedPatients = 0;
int untreatedPatients = 0;
int patients = 0;
for (int i = 1; i <= days; i++)
{
    if (i % 3 == 0)
    {
        if (treatedPatients < untreatedPatients)
        {
            doctors++;
        }
    }
    patients = int.Parse(Console.ReadLine());
    if (patients <= doctors) 
    {
        treatedPatients += patients;
    }
    else
    {
        treatedPatients += doctors;
        untreatedPatients += patients - doctors;
    }
}
Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {untreatedPatients}.");
