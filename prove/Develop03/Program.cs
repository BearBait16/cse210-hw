using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Sets the scripture reference so that it can be displayed
        Console.Clear();
        Reference _reference1 = new Reference("5", "6");
        _reference1.SetChapterName("23");
        _reference1.SetBookName("Psalms");
        _reference1.DisplayReference();

        // creates an instance of scripture with the given verses
        string verse1 = "5 Thou preparest a table before me in the presence of mine enemies: thou anointest my head with oil; my cup runneth over.";
        string verse2 = "6 Surely goodness and mercy shall follow me all the days of my life: and I will dwell in the house of the Lord for ever.";
        Scripture scripture = new Scripture(verse1, verse2);

        // splits the scriptures into 2 lists of strings
        List<string> newverse1 = new List<string>(verse1.Split(" "));
        List<string> newverse2 = new List<string>(verse2.Split(" "));


        // turns each spilt verse into an array of words
        List<Word> words1 = Word.CreateWord(newverse1);
        List<Word> words2 = Word.CreateWord(newverse2);

        // concatinates the two verses into one array
        words1.AddRange(words2);
        // calls the hidden function
        Word.RandomlyHide(words1);
        // when finished, quits the program


    }


}