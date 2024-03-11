abstract class Goals
{

    protected string goalName;
    protected string goalText;
    protected int goalPoints;

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