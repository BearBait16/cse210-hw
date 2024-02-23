class MathAssignment : Assignment
{
    string textbookSection;
    string problems;
    public MathAssignment(string textbookSection, string problems) : base(_studentName, _topic)
    {
        this.textbookSection = textbookSection;
        this.problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Textbook Pages: {textbookSection} \nProblems: {problems}";
    }
}