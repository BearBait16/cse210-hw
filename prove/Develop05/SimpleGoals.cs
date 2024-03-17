class SimpleGoals : Goals
{
    bool complete = false;
    SimpleGoals(string goalName, string goalText, int goalPoints, bool complete) : base(goalName, goalText, goalPoints)
    {
        this.goalName = goalName;
        this.goalText = goalText;
        this.goalPoints = goalPoints;
        this.complete = complete;
    }

    protected override void DisplayGoal()
    {

    }

}