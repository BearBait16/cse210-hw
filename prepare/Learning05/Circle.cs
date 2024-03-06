class Circle : Shape
{
    float radius;

    public Circle(float radius, string color) : base(color)
    {
        this.radius = radius;
        this.color = color;
    }

    public override int GetArea()
    {
        double answer = Math.PI * Math.Pow(radius, 2);
        return (int)answer;
    }
}