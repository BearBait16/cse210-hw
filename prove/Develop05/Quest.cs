using System.Collections;

public class Quest
{
    public void Menu()
    {
        bool quit = false;

        while (quit == false)
        {
            // Instantiates the points and prints
            Points points = new Points();
            int currentScore = points.GetValue();

            // Prints the Menu and Saves the choice of the User
            Console.WriteLine($"You have {currentScore} points");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Menu");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            System.Console.WriteLine("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            // Turns the User choice into an integer and 
            int choice = int.Parse(userChoice);
            switch (choice):
        {
        case 1:
            // Creates a new Goal
            System.Console.WriteLine("What type of goal would you like to set? (Input number Associated)");
                System.Console.WriteLine("  1. Simple Goal");
                System.Console.WriteLine("  2. Eternal Goal");
                System.Console.WriteLine("  3. Checklist Goal");
                string goalTypeSTR = Console.ReadLine();
                int goalType = int.Parse(goalTypeSTR);

                switch (goalType)
                {
                    case 1:
                    
                    break;
                }

            break;

        case 2:
            // List the goals made and wether or not it's complete
            break;

        case 3:
            // Writes the current Goals and score to a text file
            break;

        case 4:
            // Loads a text file into the points, goals that are completed and that aren't
            break;

        case 5:
            // Records what goal you've finished, and add the points to the current total
            break;

        case 6:
            quit = true;
            break;

        default:
            Console.WriteLine("Nope, try again");
            break;
        }
    }
}
