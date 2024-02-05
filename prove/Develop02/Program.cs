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
        Menu();
        void Menu()
        {
            System.Console.WriteLine("Welcome to the Journal writng shindig!");
            bool _quit = false;
            while (_quit == false)
            {
                // Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: Write a new entry");
                Console.WriteLine("2: Display the journal");
                Console.WriteLine("3: Save the journal to a file");
                Console.WriteLine("4: Load the journal from a file");
                Console.WriteLine("5: Quit");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Entry _currentEntry = entry.MakeEntry();
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