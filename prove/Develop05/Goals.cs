abstract class Goals
{

    protected string goalName;
    protected string goalText;
    protected int goalPoints;

    public Goals CreateGoal()
    {
        System.Console.WriteLine("What type of goal would you like to set?");
        System.Console.WriteLine("  1. Simple Goal");
        System.Console.WriteLine("  2. Eternal Goal");
        System.Console.WriteLine("  3. Checklist Goal");
        string goalType = Console.ReadLine();

        System.Console.WriteLine("How many points is your goal worth? ");
        string goalPointStr = Console.ReadLine();
        goalPoints = int.Parse(goalPointStr);

        System.Console.WriteLine("What is the name of your goal? ");
        goalName = Console.ReadLine();

        System.Console.WriteLine("What is the goal that you are setting? ");
        goalText = Console.ReadLine();


    }
    public void DisplayGoal()
    {
        System.Console.WriteLine($"Name: {goalName} Goal: {goalText} Number of Points: {goalPoints}");
    }

    public void RecordEvent(Points points)
    {
        points.SetValue(goalPoints);
    }

    Goals(string goalName, string goalText, int goalPoints)
    {
        this.goalName = goalName;
        this.goalText = goalText;
        this.goalPoints = goalPoints;
    }


}