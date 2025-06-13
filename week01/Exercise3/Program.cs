using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string gue;
        string yes = "yes";

        int mag;
        int N;
        


        while (yes == "yes")
        { 

            int attempts = 0;

            Random R = new Random();
            Console.WriteLine("Ok, I have a number, guess it ");
            mag = R.Next(1, 101);


            do
            {

                Console.WriteLine("What is your guess?: ");
                gue = Console.ReadLine();
                N = int.Parse(gue);
                attempts ++;

                if (N > mag)
                {
                    Console.WriteLine("Down below");
                }
                else if (N < mag)
                {
                    Console.WriteLine("higher up");
                }
            }
            while (mag != N);
        
                Console.WriteLine($"You Guessed it! You number is: {N}");
                Console.WriteLine($"You tried {attempts} times to win");
        Console.WriteLine("Do you whant to play agne? [yes/no]");
        yes = Console.ReadLine();
        }

    }  
}