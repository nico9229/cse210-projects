using System;

class Fraction
{
    private int _top;
    private int _botton;

    public Fraction()
    {
        _top = 1;
        _botton = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _botton = 1;
    }
    public Fraction(int top, int botton)
    {
        _top = top;
        _botton = botton;
    }

    public void Settop(int t)
    {
        _top = t;
    }
    public void SetBotton(int b)
    {
        _botton = b;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBotton()
    {
        return _botton;
    }

    public string GetFractionString()
    {
        return _top + "/" + _botton;
    }
    public double GetDecimalValue()
    {
        return (double)_top / _botton;
    }
}