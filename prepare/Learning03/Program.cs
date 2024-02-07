using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction _fraction1 = new Fraction();
        Fraction _fraction2 = new Fraction(5);
        Fraction _fraction3 = new Fraction(3, 4);

        _fraction1.SetTopNumber(1);
        _fraction1.SetBottomNumber(3);


        Console.WriteLine(_fraction3.GetBottomNumber());
        Console.WriteLine(_fraction1.GetTopNumber());

        Console.WriteLine(_fraction1.GetFractionString(_fraction1.GetTopNumber(), _fraction1.GetBottomNumber()));
    }
}