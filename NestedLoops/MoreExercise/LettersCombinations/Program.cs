char first = char.Parse(Console.ReadLine());
char second = char.Parse(Console.ReadLine());
char skipped  = char.Parse(Console.ReadLine());
string skiped = "";

int counter  = 0;
string combination = "";

for (char i = first; i <= second; i++)
{
    for (char j = first; j <= second; j++)
    {
        for (char k = first; k <= second; k++)
        {
            string firstLetter = char.ToString(i);
            string secondLetter = char.ToString(j);
            string thirdLetter = char.ToString(k);

            skiped = char.ToString(skipped);

            if (firstLetter != skiped && secondLetter != skiped && thirdLetter != skiped)
            {
                counter++;
                combination = firstLetter + secondLetter + thirdLetter + " ";
                Console.Write(combination);
            }
        }
    }
}
Console.Write(counter);