abstract class Goals
{

    protected string goalName;
    protected string goalText;
    protected int goalPoints;

    public void CreateGoal()
    {
        System.Console.WriteLine("How many points is your goal worth? ");
        string goalPointStr = Console.ReadLine();
        goalPoints = int.Parse(goalPointStr);

        System.Console.WriteLine("What is the name of your goal? ");
        goalName = Console.ReadLine();

        System.Console.WriteLine("What is the goal that you are setting? ");
        goalText = Console.ReadLine();

    }
    public virtual void DisplayGoal()
    {
        System.Console.WriteLine($"Name: {goalName} Goal: {goalText} Number of Points: {goalPoints}");
    }

    public void RecordEvent(Points points)
    {
        points.SetValue(goalPoints);
    }

    protected Goals(string goalName, string goalText, int goalPoints)
    {
        this.goalName = goalName;
        this.goalText = goalText;
        this.goalPoints = goalPoints;
    }



}