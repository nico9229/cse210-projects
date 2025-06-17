using System;
class Runing : Activity
{
    private double _distance;
    public Runing(double distance, string date, int duration) : base(date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }
    public override double GetPace()
    {
        return GetDuration() / _distance;
    }
        public override void GetSummary()
    {
        Console.WriteLine("\n  Summary  ");
        Console.WriteLine("===========");
        Console.WriteLine("");
        Console.WriteLine($"{GetDate()} - Running ({GetDuration} : min.)");
        Console.WriteLine($"Distance: {GetDistance()} km.");
        Console.WriteLine($"Speed: {GetSpeed()} kph.");
        Console.WriteLine($"Pace: {GetPace()} min/km\n");
        Console.WriteLine("===============================");
    }
}