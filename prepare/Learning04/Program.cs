using System;

class Programs
{
    static void Main(string[] args)
    {
        Assignment first = new Assignment("Jackson", "To be Better");
        System.Console.WriteLine(first.GetSummary());
        MathAssignment second = new MathAssignment("Chapter 4", "33-38");
        second.Set_StudentName("Jackson");
        second.Set_Topic("Calc 1");
        System.Console.WriteLine(second.GetSummary());
        System.Console.WriteLine(second.GetHomeworkList());
        WritingAssignment third = new WritingAssignment("Farenheit 451");
        third.Set_Topic("English");
        third.Set_StudentName("Jackson");
        System.Console.WriteLine(third.GetSummary());
        System.Console.WriteLine(third.GetWritingInformation());

    }
}