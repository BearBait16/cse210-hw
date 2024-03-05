class Breathing : Activity
{
    public void BreathingStart()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

        // asks for the user amount of time in the activity, and turns that into a float

        Console.WriteLine("How many seconds would you like to spend on this excersize?");
        var timeLimit = float.Parse(Console.ReadLine());


        // calls the loading spinny thing
        SpinningLine();
        // runs the timer and the breathing excersize here
        DateTime userGivenTime = DateTime.Now.AddSeconds(timeLimit);
        DateTime currentTime = DateTime.Now;
        while (currentTime != userGivenTime)
        {
            BreathingExcersize();
        }
        // when the time spent in the excersize is the amount of time input by the user, it finishes the program

        // exits the function when the amount of excersizes is finished
    }

    void BreathingExcersize()
    {
        var breathIn = 4;

        var breathOut = 8;

        while (breathIn > 0)
        {
            Console.WriteLine("Breath in..." + breathIn);
            Thread.Sleep(1000);
            breathIn -= 1;
        }

        while (breathOut > 0)
        {
            Console.WriteLine("Breath out..." + breathOut);
            Thread.Sleep(1000);
            breathOut -= 1;
        }
    }
}
