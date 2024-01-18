using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 100);
        bool correct = false;
        int numGuesses = 0;

        do
        {
            System.Console.WriteLine("What is your guess?");
            int guess = int.Parse(Console.ReadLine());

            if (random < guess)
            {
                System.Console.WriteLine("Your number is too high, try agian");
            }
            else if (random > guess)
            {
                System.Console.WriteLine("Your number is too low, try agian");
            }
            else if (random == guess)
            {
                System.Console.WriteLine("Correct!");
                correct = true;
            }
            numGuesses++;
        } while (correct != true);

        System.Console.WriteLine($"You guessed {numGuesses} times.");

    }
}