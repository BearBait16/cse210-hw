using System;
using System.Dynamic;

public class Fraction
{
    private float _topNumber;
    private float _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public float GetTopNumber()
    {
        float strTopNum = _topNumber;
        return strTopNum;

    }
    public float GetBottomNumber()
    {
        float BottomNum = _bottomNumber;
        return BottomNum;
    }

    public void SetTopNumber(float topNumber)
    {
        _topNumber = topNumber;
    }

    public void SetBottomNumber(float bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public string GetFractionString(float topNumber, float bottomNumber)
    {
        string _fractionString = $"{topNumber}/{bottomNumber}";
        return _fractionString;
    }

    public float GetDecimalValue(float topNumber, float bottomNumber)
    {
        float _decimalValue = topNumber / bottomNumber;
        return _decimalValue;
    }
}