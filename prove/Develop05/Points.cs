public class Points
{
    // This class stores points for display, saving, and loading. It will be a simple integer
    int value;

    public void SetValue(int score)
    {
        value = value + score;
    }

    public int GetValue()
    {
        return value;
    }
}