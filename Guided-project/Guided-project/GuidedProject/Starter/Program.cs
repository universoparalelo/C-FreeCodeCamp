using System;

// initialize variables - graded assignments 
int examsAssignments = 5;

int[] sophiaGrades = {90, 86, 87, 98, 100, 90, 94};
int[] andrewGrades = {92, 89, 81, 96, 90, 89};
int[] emmaGrades = {90, 85, 87, 98, 68, 89, 89, 89};
int[] loganGrades = {90, 95, 87, 88, 96, 96};
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 }; 

string[] studentNames = {"Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"};

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\t\tOverall\t Grade\tExtra Credit\n");

foreach(string name in studentNames){

    string currentStudent = name;

    if(currentStudent == "Sophia")
        studentScores = sophiaGrades;
    
    else if(currentStudent == "Andrew")
        studentScores = andrewGrades;
    
    else if(currentStudent == "Emma")
        studentScores = emmaGrades;
    
    else if (currentStudent == "Logan")
        studentScores = loganGrades;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    
    decimal gradesSum = 0;
    int gradesAssignments = 0;
    decimal studentScore;
    decimal overallStudentScore = 0;

    decimal extraCreditSum = 0;
    int extraCreditAssignments = 0;
    decimal extraCreditStudentScore;

    foreach(int score in studentScores){
        if (gradesAssignments >= examsAssignments){
            if (extraCreditAssignments==0)
                overallStudentScore = gradesSum / 5.0m;
            gradesSum += ((decimal)score/10);
            extraCreditSum += score;
            extraCreditAssignments++;
        }
        else
            gradesSum += score;

        gradesAssignments ++;
    }
    
    studentScore = gradesSum / (decimal)examsAssignments;
    extraCreditStudentScore = extraCreditSum / (decimal)extraCreditAssignments;

    if(studentScore >= 97)
        currentStudentLetterGrade = "A+";
    
    else if(studentScore >= 93)
        currentStudentLetterGrade = "A";
    
    else if(studentScore >= 90)
        currentStudentLetterGrade = "A-";
    
    else if(studentScore >= 87)
        currentStudentLetterGrade = "B+";
    
    else if(studentScore >= 83)
        currentStudentLetterGrade = "B";
    
    else if(studentScore >= 80)
        currentStudentLetterGrade = "B-";
    
    else if(studentScore >= 77)
        currentStudentLetterGrade = "C+";
    
    else if(studentScore >= 73)
        currentStudentLetterGrade = "C";
    
    else if(studentScore >= 70)
        currentStudentLetterGrade = "C-";
    
    else if(studentScore >= 67)
        currentStudentLetterGrade = "D+";
    
    else if(studentScore >= 63)
        currentStudentLetterGrade = "D";
    
    else if(studentScore >= 60)
        currentStudentLetterGrade = "D-";
    
    else
        currentStudentLetterGrade = "F";
    


    Console.WriteLine($"{name}\t\t{overallStudentScore}\t\t{studentScore}\t{currentStudentLetterGrade}\t{extraCreditStudentScore} ({studentScore - overallStudentScore}pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
