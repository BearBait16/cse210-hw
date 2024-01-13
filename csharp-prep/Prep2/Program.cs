using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string gradeString = Console.ReadLine();
        float gradeFloat = float.Parse(gradeString);

        bool passBool = true;

        string grade = "A";

        if (gradeFloat >= 90)
        {
            grade = "A";
        }
        else if (gradeFloat >= 80)
        {
            grade = "B";
        }
        else if (gradeFloat >= 70)
        {
            grade = "C";
        }
        else if (gradeFloat >= 60)
        {
            grade = "D";
            passBool = false;
        }
        else if (gradeFloat < 60)
        {
            grade = "F";
            passBool = false;
        }

        Console.WriteLine(grade);

        if (passBool == true)
        {
            Console.WriteLine($"You passed the class");
        }
        else if (passBool == false)
        {
            Console.WriteLine($"You failed the class");
        }

    }
}