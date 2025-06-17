using System;
class Swiming : Activity
{
    private double _laps;
    public Swiming(double laps, string date, int duration) : base(date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public override void GetSummary()
    {
        Console.WriteLine("\n  Summary  ");
        Console.WriteLine("===========");
        Console.WriteLine("");
        Console.WriteLine($"{GetDate()} - Swiming ({GetDuration} : min.)");
        Console.WriteLine($"Distance: {GetDistance()} km.");
        Console.WriteLine($"Speed: {GetSpeed()} kph.");
        Console.WriteLine($"Pace: {GetPace()} min/km\n");
        Console.WriteLine("===============================");
    }
    

}