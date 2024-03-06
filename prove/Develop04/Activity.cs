public class Activity
{
    public void DisplayActivityStart()
    {
        System.Console.WriteLine("Welcome to this mindfulness Activity");
    }

    public void DisplayActivityEnd()
    {
        System.Console.WriteLine("You've completed a mindfulness Activity! Good Job!");
    }

    static public void SpinningLine()
    {
        List<string> lineStrings = new List<string>();
        lineStrings.Add("|");
        lineStrings.Add("/");
        lineStrings.Add("-");
        lineStrings.Add("\\");
        lineStrings.Add("|");
        foreach (string i in lineStrings)
        {
            Console.Write(i);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

        int y = 0;

        while (DateTime.Now < endTime)
        {
            string s = lineStrings[y];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            y = y + 1;

            if (y >= lineStrings.Count)
            {
                y = 0;
            }
        }

    }
}