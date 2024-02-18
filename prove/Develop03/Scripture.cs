class Scripture
{
    private string verse1;
    private string verse2;

    void DisplayScripture()
    {
        Console.WriteLine();
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