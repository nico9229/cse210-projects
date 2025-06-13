using System;
using System.Collections.Generic;
class ReflectingActivity : Activity
{
    private List<string> _promnt = new List<string>();
    private List<string> _question = new List<string>();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times when you have shown strength and resilience.",0)
    {
        _promnt.Add("Think of a time when you stood up for someone else.");
        _promnt.Add("Think of a time when you did something really difficult.");
        _promnt.Add("Think of a time when you helped someone in need.");
        _promnt.Add("Think of a time when you did something truly selfless.");

        _question.Add("Why was this experience meaningful to you?");
        _question.Add("Have you ever done anything like this before?");
        _question.Add("How did you get started?");
        _question.Add("How did you feel when it was complete?");
        _question.Add("What made this time different than other times when you were not as successful?");
        _question.Add("What is your favorite thing about this experience?");
        _question.Add("What could you learn from this experience that applies to other situations?");
        _question.Add("What did you learn about yourself through this experience?");
        _question.Add("How can you keep this experience in mind in the future?");


    
    }

    public void Run()
    {
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue...");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience:");
        ShowSpinner(5);

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine($"> {GetRandomQuestion()}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    }
    //***************************************
    public string GetRandomPrompt()
    {
        Random r = new Random();
        int i = r.Next(_promnt.Count);
        return _promnt[i];
    }
        public void DisplayPrompt()
    {
        Console.WriteLine("Consider the Following promt: ");
        Console.WriteLine($"=== {GetRandomPrompt()} ===");
    }
    //***************************************
    public string GetRandomQuestion()
    {
        Random r = new Random();
        int i = r.Next(_question.Count);
        return _question[i];
    }
        public void DisplayQuestion()
    {
        Console.WriteLine("Now ponder on this Question: ");
        Console.WriteLine($">>> {GetRandomQuestion()}");
    }


}