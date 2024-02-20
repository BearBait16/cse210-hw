using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Word
{
    string text;
    bool hidden;
    int lengthOfWord;
    public string GetText(Word word)
    {
        return word.text;
    }
    Word(int length, string Oldtext)
    {

        lengthOfWord = length;
    }
    static public List<Word> CreateWord(List<string> verse)
    {
        List<Word> wordList = new List<Word>();

        foreach (string item in verse)
        {

            int length = item.Length;
            Word word = new Word(length, item);
            wordList.Add(word);
        }
        return wordList;
    }
    // Takes a given words length, then converts the 
    static public Word Hide(Word thisWord)
    {
        int wordLength = thisWord.lengthOfWord;
        thisWord.text = string.Concat(Enumerable.Repeat("-", wordLength));
        thisWord.hidden = true;
        return thisWord;
    }
    // Makes a bunch of random indexes, checks 
    // if there are any words within the array that are revealed,
    // and hides the given indexs 
    static public void RandomlyChoose(List<Word> words)
    {
        Random randomIndex = new Random();
        List<int> chosenIndexList = new List<int>();
        List<int> alreadyHiddenList = new List<int>();
        foreach (Word word in words)
        {
            if (word.hidden == false)
            {
                chosenIndexList.Add(words.IndexOf(word));
            }
            else if (word.hidden == true)
            {
                alreadyHiddenList.Add(words.IndexOf(word));
            }
            // Take the indexes needed, cycle them through the words list, then hide all those words
            foreach (int index in chosenIndexList)
            {
                Word currentWord = words[index];
                Word.Hide(currentWord);
            }
        }
    }
}