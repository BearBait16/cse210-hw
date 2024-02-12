using System.Reflection.Metadata.Ecma335;

public class Reference
{
    private string _verseName;
    private string _chapterName;
    private string _bookName;

    public void DisplayReference()
    {
        Console.WriteLine($"{_bookName} {_chapterName}:{_verseName}");
    }
    public Reference(string verse)
    {

    }
    public Reference(string firstVerse, string endVerse)
    {
        _verseName = firstVerse + "-" + endVerse;
    }
    public string GetBookName()
    {
        return _bookName;
    }
    public string GetChapterName()
    {
        return _chapterName;
    }
    public string GetVerseName()
    {
        return _verseName;
    }
    public void SetBookName(string input)
    {
        _bookName = input;
    }
    public void SetChapterName(string input)
    {
        _chapterName = input;
    }
}