using System;


class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int bonus) : base(name, description, bonus)
    {

    }
    public override int RecordEvent()
    {
        return _point;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return $"EternalGoal|{_ShortName}|{_description}|{_point}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_ShortName}|{_description}|{_point}";
    }


}