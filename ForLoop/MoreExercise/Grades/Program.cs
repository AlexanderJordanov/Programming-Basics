int students = int.Parse(Console.ReadLine());
int firstGroup = 0;
int secondGroup = 0;
int thirdGroup = 0;
int fourthGroup = 0;
double totalExamGrade = 0;
for  (int i = 0; i < students; i++)
{
    double examGrade = double.Parse(Console.ReadLine());
    totalExamGrade += examGrade;
    if (examGrade < 3) 
    { 
        firstGroup++; 
    }
    else if (examGrade >= 3 && examGrade < 4)
    {
        secondGroup++;
    }
    else if (examGrade >= 4 && examGrade < 5)
    {
        thirdGroup++;
    }
    else if (examGrade >= 5)
    {
        fourthGroup++;
    }
}

double averageGrade = totalExamGrade / students;

double firstGroupPercentage = 100.0 * firstGroup / students;
double secondGroupPercentage = 100.0 *  secondGroup / students;
double thirdGroupPercentage = 100.0 * thirdGroup / students;
double fourthGroupPercentage = 100.0 * fourthGroup / students;

Console.WriteLine($"Top students: {fourthGroupPercentage:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {thirdGroupPercentage:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {secondGroupPercentage:f2}%");
Console.WriteLine($"Fail: {firstGroupPercentage:f2}%");
Console.WriteLine($"Average: {averageGrade:f2}");
