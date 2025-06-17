using System;
class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, string date, int duration) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override void GetSummary()
    {
        Console.WriteLine("\n  Summary  ");
        Console.WriteLine("===========");
        Console.WriteLine("");
        Console.WriteLine($"{GetDate()} - Cycling ({GetDuration()} : min.)");
        Console.WriteLine($"Distance: {GetDistance()} km.");
        Console.WriteLine($"Speed: {GetSpeed()} kph.");
        Console.WriteLine($"Pace: {GetPace()} min/km\n");
        Console.WriteLine("===============================");
    }

}