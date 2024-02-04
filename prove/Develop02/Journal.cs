namespace JournalWriter;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        System.Console.WriteLine(_entries);
    }
    public void Save()
    {
        System.Console.WriteLine("Write the name of the file you would like to save too. IE example.txt");
        var _textFileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_textFileName))
        {
            outputFile.WriteLine("Date");
            outputFile.WriteLine(Program.journal._entries);
        }
    }

    public void Load()
    {

    }

}