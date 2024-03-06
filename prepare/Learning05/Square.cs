public class Square : Shape
{
    private int side;
    public Square(int side, string color) : base(color)
    {
        this.side = side;
        this.color = color;
    }

    public void SetSide(int input)
    {
        side = input;
    }
    public override int GetArea()
    {
        return side * side;
    }

}