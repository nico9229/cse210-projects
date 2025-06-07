using System;
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.", 0)

    {

    }
    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int cycles = duration / 10;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(4);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }

}