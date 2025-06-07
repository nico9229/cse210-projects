using System;
using System.Threading;
using System.Collections.Generic;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
       
    }

    //****************************************
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    //*****************************************

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity !");
        Console.WriteLine(_description);
        Console.WriteLine($"How long (in second) would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get redy. . . ");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!! ");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {_name}.\n");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < end)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }

    }
    public void ShowCountDown(int second)
    {   
       
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(second);

        int i = 0;

        while (DateTime.Now < end)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }

    

    }
}