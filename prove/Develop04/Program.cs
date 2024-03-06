using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        var quit = false;
        while (quit == false)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("");

            string userChoicestr = Console.ReadLine();

            int userChoiceint = int.Parse(userChoicestr);

            switch (userChoiceint)
            {
                case 1:
                    Breathing breathing = new Breathing();
                    breathing.BreathingStart();
                    break;
                case 2:
                    Reflecting reflecting = new Reflecting();
                    reflecting.ReflectionStart();
                    break;
                case 3:
                    Listing listing = new Listing();
                    listing.ListingStart();
                    break;
                case 4:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Nope");
                    break;
            }
        }

        // Display Menu

        // When activity is chosen, it calls whatever activity's run
    }
}