using System;
class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompt = new List<string>();

    public ListingActivity() : base("Listing Activity", "this activity will help you reflect on the good things in your life by having you list as many things as you can in a certain   area.", 0)
    {
       

        _prompt.Add("Who are people that you appreciate?");
        _prompt.Add("What are personal strengths of yours?");
        _prompt.Add("Who are people that you have helped this week?");
        _prompt.Add("When have you felt the Holy Ghost this month?");
        _prompt.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in:");
        ShowSpinner(5);

        List<string> responses = new List<string>();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        _count = 0;
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string r = Console.ReadLine();
            responses.Add(r);
            
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");
        ShowSpinner(3);
        DisplayEndingMessage();
    }

    //este metodo me devolvera de manera random las Prompt
    public string GetRandomPrompt()
    {

        Random rand = new Random();
        int index = rand.Next(_prompt.Count);
        return _prompt[index]; //mi variable  con instrucciones 
    }
    
}