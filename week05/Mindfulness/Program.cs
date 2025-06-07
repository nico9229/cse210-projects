using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity a = new BreathingActivity();
                a.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
            }
            else if (choice == "3")
            {
                ListingActivity a = new ListingActivity();
                a.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Plis Enter to continue.");
                Console.WriteLine();
            }


        }
    }
}