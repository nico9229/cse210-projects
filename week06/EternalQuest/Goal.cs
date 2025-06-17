using System;
using System.Collections.Generic;


public abstract class Goal
{
    protected string _ShortName;
    protected string _description;
    protected int _point;

    public Goal(string name, string description, int point)
    {
        _ShortName = name;
        _description = description;
        _point = point;
    }
    public string GetShortName()
    {
        return _ShortName;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
    
}