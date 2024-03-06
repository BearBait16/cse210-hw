public class Shape
{
    public string color;

    public virtual int GetArea()
    {
        return 2;
    }
    public string GetColor()
    {
        return color;
    }

    public void SetColor(string input)
    {
        color = input;
    }

    public Shape(string color)
    {
        this.color = color;
    }
}