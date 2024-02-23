using System;
using System.Runtime.CompilerServices;
public class Assignment
{
    static protected string _studentName;
    static protected string _topic;
    public string GetSummary()
    {
        string summary = $"Name: {_studentName} Topic: {_topic}";
        return summary;
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;

    }
    public string Get_StudentName()
    {
        return _studentName;
    }
    public void Set_StudentName(string input)
    {
        _studentName = input;
    }
    public string Get_Topic()
    {
        return _topic;
    }
    public void Set_Topic(string input)
    {
        _topic = input;
    }
}
