using System.Net;

public class WritingAssignment : Assignment
{
    protected string title;
    public WritingAssignment(string title) : base(_studentName, _topic)
    {
        this.title = title;
    }
    public string GetWritingInformation()
    {
        return $"Title: {title}";
    }
}