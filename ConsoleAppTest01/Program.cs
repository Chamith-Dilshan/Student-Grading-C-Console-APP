String[] studentNames = { "sophia", "andrew", "emma", "logan" };
int currentAssignment = 5;
Char[] studentsGrade = new Char[4];

int[] sophiaScores = { 90,86,87,98,100};
int[] andrewScores = { 92,89,81,96,90};
int[] emmaScores = { 90,85,87,98,68};
int[] loganScores = { 90,95,87,88,96};

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

foreach (int sophia_Score in sophiaScores) {
    sophiaSum += sophia_Score;
}
foreach (int andrew_Scores in andrewScores)
{
    andrewSum += andrew_Scores;
}
foreach (int emma_Scores in emmaScores)
{
    emmaSum += emma_Scores;
}
foreach (int logan_Scores in loganScores)
{
    loganSum += logan_Scores;
}

decimal sophiaScore = (decimal) sophiaSum/currentAssignment;
decimal andrewScore = (decimal)andrewSum / currentAssignment;
decimal emmaScore = (decimal)emmaSum / currentAssignment;
decimal loganScore = (decimal)loganSum / currentAssignment;

decimal[] studentScores = { sophiaScore, andrewScore, emmaScore, loganScore };

for (int i = 0 ; i< studentScores.Length; i++)
{
    if (studentScores[i] >= 75 && studentScores[i] <= 100)
    {
        studentsGrade[i] = 'A';
    }
    else if (studentScores[i] < 75 && studentScores[i] >= 65) {
        studentsGrade[i] = 'B';
    }
    else if (studentScores[i] < 65 && studentScores[i] >= 45)
    {
        studentsGrade[i] = 'C';
    }
    else if (studentScores[i] < 45)
    {
        studentsGrade[i] = 'F';
    }
}
Console.WriteLine("Student\t\t\tGrade\n");
for (int i= 0; i < studentNames.Length; i++) {
    Console.WriteLine($"{studentNames[i]}\t\t\t{studentScores[i]}\t\t{studentsGrade[i]}");
}