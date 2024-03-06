class Rectangle : Shape
{
    int side1;
    int side2;
    public Rectangle(int side1, int side2, string color) : base(color)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.color = color;
    }

    public override int GetArea()
    {
        return side1 * side2;
    }
}