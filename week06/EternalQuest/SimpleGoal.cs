using System;

public class SimpleGoal : Goal
{
    private bool _isComplet;
    private int _amountComplet;
    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    {
        _isComplet = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplet)
        {
            _isComplet = true;
            return _point;
        }
        else
        {
            Console.WriteLine("This goal is already completed!");
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplet;
    }
    public override string GetDetailsString()
    {
        string status = _isComplet ? "[X]" : "[ ]";
        return $"{status} {_ShortName} ({_description})";
    }
        public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_ShortName}, {_description},{_point},{_isComplet}";
    }

    public void SetComplete(bool value)
    {
        _isComplet = value;
    }
    public void SetAmountComplet(int value)
    {
        _amountComplet = value;
    }
    
}