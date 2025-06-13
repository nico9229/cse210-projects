using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startingAge;
    public int _endAge;

    public void DisplayJobDetails()
    {
        Console.WriteLine(_jobTitle);
        Console.WriteLine(_company);
        Console.WriteLine($"{_startingAge} - {_endAge}");
        Console.WriteLine();

    }
}