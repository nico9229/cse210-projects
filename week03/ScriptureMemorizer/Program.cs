using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Nefi", 3, 7);
        string text = "I will go and do the things which the Lord hath commanded";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2); 
        }

        Console.WriteLine("\nProgram ended.");
    }
}