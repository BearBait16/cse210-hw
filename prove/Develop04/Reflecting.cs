class Reflecting : Activity
{
    public void ReflectionStart()
    {
        Console.Clear();
        DisplayActivityStart();
        SpinningLine();

        System.Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Activity.SpinningLine();

        Console.Clear();

        Console.WriteLine("How long would you like this activity to go?");
        var timeLimit = float.Parse(Console.ReadLine());

        Console.Clear();

        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];

        List<string> reflections = new List<string>();
        reflections.Add("Why was this experience meaningful to you?");
        reflections.Add("Have you ever done anything like this before?");
        reflections.Add("How did you get started?");
        reflections.Add("How did you feel when it was complete?");
        reflections.Add("What made this time different than other times when you were not as successful?");
        reflections.Add("What is your favorite thing about this experience?");
        reflections.Add("What could you learn from this experience that applies to other situations?");
        reflections.Add("What did you learn about yourself through this experience?");
        reflections.Add("How can you keep this experience in mind in the future?");

        DateTime userGivenTime = DateTime.Now.AddSeconds(timeLimit);
        DateTime currentTime = DateTime.Now;
        while (currentTime < userGivenTime)
        {
            Random random2 = new Random();
            int randomInxed2 = random2.Next(reflections.Count);
            string randomReflection = reflections[randomInxed2];
            System.Console.WriteLine(randomReflection);

            Thread.Sleep(3000);

            currentTime = DateTime.Now;
        }
        Console.Clear();
        DisplayActivityEnd();
        SpinningLine();
    }
}