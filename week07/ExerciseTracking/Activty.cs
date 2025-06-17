using System;

abstract class Activity
{
    private string _date;
    private int _duration;
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date;
    }
    public double GetDuration()
    {
        return _duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual void GetSummary()
    {
        Console.WriteLine("\n  Summary  ");
        Console.WriteLine("===========");
        Console.WriteLine("");
        Console.WriteLine($"{_date} - unknown ({_duration} : min.)");
        Console.WriteLine($"Distance: {GetDistance()} km.");
        Console.WriteLine($"Speed: {GetSpeed()} kph.");
        Console.WriteLine($"Pace: {GetPace()} min/km\n");
        Console.WriteLine("===============================");
    }

}