using System;

class Program
{
    static void Main(string[] args)
    {
        // Sets the scripture reference so that it can be displayed
        Reference _reference1 = new Reference("5", "6");
        _reference1.SetChapterName("23");
        _reference1.SetBookName("Psalms");
        _reference1.DisplayReference();
    }
}