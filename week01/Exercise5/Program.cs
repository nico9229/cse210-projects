using System;
using System.Numerics;
using System.Xml.XPath;

class Program
{
  
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }


    static void PromptUserName(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    static void PromptUserNumber(int number)
    {
        Console.WriteLine($"Your favorit number is: {number}");
    }

    static int SquareNumber(int number)
         
    { 

        double Total = Math.Pow(number, 2);

        return (int) Total;
    }

    static void DisplayResult(string name, int number)
    {
        PromptUserName(name);
        int sQ = SquareNumber(number);
        Console.WriteLine($"Brother {name}, the square of your number is: {sQ}");
    }
    static void Main(string[] args)
    {
       DisplayMessage();

       Console.WriteLine("Please enter your name: ");
       string  name = Console.ReadLine();
       
       Console.WriteLine("Please enter your favorite number: ");
       int number = int.Parse(Console.ReadLine());
       PromptUserNumber(number);
       DisplayResult(name, number);
    }
}