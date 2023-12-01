List<string> studentNames = new List<string>();
List<string> studentSubjects = new List<string>();
List<double> studentsAvg = new List<double>();
List<char> studentsGrade = new List<char>();

int studentCount = 0;
int subjectCount = 0;

// take student names
Console.WriteLine("Enter Student's Names here(Type 'done' when finished) -");
while (true)
{
    Console.WriteLine($"\nStudent Name {studentCount} :");
    studentCount++;
    string input = Console.ReadLine();
    if (input.ToLower() == "done")
    {
        break;
    }
    studentNames.Add(input);
}

// take subject names
Console.WriteLine("\nEnter Student's subject here(Type 'done' when finished) -");
while (true)
{
    Console.WriteLine($"\nsubject {subjectCount} :");
    subjectCount++;
    string input = Console.ReadLine();
    if (input.ToLower() == "done")
    {
        break;
    }
    studentSubjects.Add(input);
}

// take scores
foreach (string studentName in studentNames)
{
    Console.WriteLine($"\nEnter Scores For Student - {studentName}:\n");
    Dictionary<string, List<int>> subjectScores = new Dictionary<string, List<int>>();

    foreach (string studentSubject in studentSubjects)
    {
        List<int> scoresList = new List<int>();

        while (true)
        {
            Console.Write($"Enter score for {studentSubject} (Type 'done' when finished): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
            {
                break;
            }

            // Validate and add the score to the list
            if (int.TryParse(input, out int score))
            {
                scoresList.Add(score);
                Console.WriteLine($"Added score {score} for {studentName} in {studentSubject}\n");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid score.");
            }
        }

        // Add the list of scores to the subjectScores dictionary
        subjectScores.Add(studentSubject, scoresList);
    }

    // Calculate average for the student and add to the studentsAvg list
    double averageScore = subjectScores.Values.SelectMany(x => x).Average();
    studentsAvg.Add(averageScore);
    Console.WriteLine($"Average score for {studentName}: {averageScore}\n");
}

for (int i = 0; i < studentsAvg.Count; i++)
{
    if (studentsAvg[i] >= 75 && studentsAvg[i] <= 100)
    {
        studentsGrade.Add('A');
    }
    else if (studentsAvg[i] < 75 && studentsAvg[i] >= 65)
    {
        studentsGrade.Add('B');
    }
    else if (studentsAvg[i] < 65 && studentsAvg[i] >= 45)
    {
        studentsGrade.Add('C');
    }
    else if (studentsAvg[i] < 45)
    {
        studentsGrade.Add('F');
    }
    else {
        studentsGrade.Add('O');
    }
}
Console.WriteLine("Student\t\t\tGrade\n");
for (int i = 0; i < studentNames.Count; i++)
{
    Console.WriteLine($"{studentNames[i]}\t\t\t{studentsAvg[i]}\t\t{studentsGrade[i]}");
}
