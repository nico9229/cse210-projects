using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment w = new WritingAssignment("Nicolas Ayala", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetTitle());
    }
}