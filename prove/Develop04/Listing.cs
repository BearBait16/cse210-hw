class Listing : Activity
{
    // this class has a list of prompts that will be randomly called

    public void ListingStart()
    {
        DisplayActivityStart();
        // displays the start activity code with the correct parameters

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        // asks for the user number of seconds they want to spend on the activity
        Console.WriteLine("How long would you like this activity to go?");
        var timeLimit = float.Parse(Console.ReadLine());
        // runs a function that calls the random prompt, and posts it
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");


        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];

        Console.Clear();

        Console.WriteLine(randomPrompt);
        Thread.Sleep(1000);

        // then runs a function that counts down x number of seconds and runs the animation, giving them time to think about the prompt
        Console.WriteLine("Think about this prompt");

        Activity.SpinningLine();

        // everytime the readline enter is pressed, the function checks how much time has passed

        DateTime userGivenTime = DateTime.Now.AddSeconds(timeLimit);
        DateTime currentTime = DateTime.Now;
        while (currentTime < userGivenTime)
        {
            Console.ReadLine();
            currentTime = DateTime.Now;
        }

        // if the time passed is equal to or greater then the time given, then end the activity

        // end message
        DisplayActivityEnd();
        SpinningLine();
    }
}