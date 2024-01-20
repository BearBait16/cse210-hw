using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        System.Console.Write("Give me one more integer! ");
        int newNumber = int.Parse(Console.ReadLine());
        int product = PromptSquareNumber(newNumber);
        DisplayResult(product, userName);

        static void DisplayWelcome()
        {
            System.Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            System.Console.WriteLine($"Nice to meet you {userName}");
            return userName;
        }
        static int PromptUserNumber()
        {
            System.Console.Write("What is your favorite integer? ");
            int favNum = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"{favNum} is my favorite too!");
            return favNum;
        }



        static int PromptSquareNumber(int newNumber)
        {
            int product = newNumber * newNumber;
            return product;
        }
        static void DisplayResult(int product, string userName)
        {
            System.Console.WriteLine($"{userName}, the square of your number is {product}.");
        }
    }
}