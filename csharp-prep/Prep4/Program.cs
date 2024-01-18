using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> userInts = new List<int>();
        bool finishLoop = false;
        int largestInt = 0;


        while (finishLoop != true)
        {
            Console.WriteLine("Input integer, input 0 if finished. ");
            int numNew = int.Parse(Console.ReadLine());
            if (numNew > largestInt)
            {
                largestInt = numNew;
            }
            if (numNew != 0)
            {
                userInts.Add(numNew);
            }
            else if (numNew == 0)
            {
                finishLoop = true;
            }
        }
        double averageInt = userInts.Average();
        int sumInt = userInts.Sum();
        System.Console.WriteLine($"The Sum is {sumInt}");
        System.Console.WriteLine($"The Average of the numbers is {averageInt}");
        System.Console.WriteLine($"The Largest number in the list is {largestInt}");

    }
}