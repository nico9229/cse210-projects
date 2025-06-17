using System;
using System.Collections.Generic;

class CheckListGoal : Goal
{
    private int _amountComplet;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
        _amountComplet = 0;
    }
    public override int RecordEvent()
    {
        if (_amountComplet >= _target)
        {
            Console.WriteLine("This goal is already complete.");
            return 0;
        }

        _amountComplet++;

        if (_amountComplet == _target)
        {
            return _point + _bonus;
        }
        else
        {
            return _point;
        }
    }
    public override bool IsComplete()
    {
        return _amountComplet >= _target;
    }
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_ShortName} ({_description}) -- Completed: {_amountComplet}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_ShortName}|{_description}|{_point}|{_bonus}|{_target}|{_amountComplet}";
    }
    public void SetAmountCompleted(int amount)
    {
        _amountComplet = amount;
    }

}