using System.Net.NetworkInformation;

class Scripture
{
    private string verse1;
    private string verse2;

    static public void DisplayScripture(List<Word> words)
    {
        foreach (Word word in words)
        {
            string Text = word.GetText(word);
            System.Console.WriteLine(Text);
        }
    }


    public Scripture(string verse)
    {
        verse1 = verse;
    }
    public Scripture(string firstVerse, string secondVerse)
    {
        verse1 = firstVerse;
        verse2 = secondVerse;
    }
}