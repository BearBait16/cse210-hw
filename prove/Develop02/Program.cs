using System;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
namespace JournalWriter;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        Entry entry = new Entry();

        void Menu()
        {
            System.Console.WriteLine("Welcome to the Journal writng shindig!");
            System.Console.WriteLine("What would you like to do?");
            System.Console.WriteLine("1: Write a new entry");
            System.Console.WriteLine("2: Display the journal");
            System.Console.WriteLine("3: Save the journal to a file");
            System.Console.WriteLine("4: Load the journal from a file");
            System.Console.WriteLine("5: Quit");
            string choice = Console.ReadLine();
            bool _quit = false;
            while (_quit == false)
            {
                if (choice == "1")
                {
                    string _currentEntry = entry.MakeEntry();
                    journal._entries.Add(_currentEntry);
                }
                else if (choice == "2")
                {
                    journal.Display();
                }
                else if (choice == "3")
                {
                    journal.Save();
                }
                else if (choice == "4")
                {
                    journal.Load();
                }
                else if (choice == "5")
                {
                    System.Console.WriteLine("Thank You!");
                    _quit = true;
                }
                else
                {
                    System.Console.WriteLine("Unrecognized, please try again.");
                }
            }

        }

    }
}