using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage?: ");
        string per = Console.ReadLine();
        double number = double.Parse(per);

        string letter; 
// in this part we can to fine abaut A 
        if (number >= 93 && number <= 100)
        {
            letter = "A";
        }
        else if (number >= 90 && number < 93)
        {
            letter = "A-";
        }
// in this part we can to fine about B
        else if (number >= 87 && number < 90)
        {
            letter = "B+";
        }

        else if (number >= 83 && number < 87)
        {
            letter = "B";
        }

        else if (number >= 80 && number < 83)
        {
            letter = "B-";
        }
// in this part we can to fine about c

        else if (number >= 77 && number < 80)
        {
            letter = "C+";
        }

        else if (number >= 73 && number < 77)
        {
            letter = "C";
        }

        else if (number >= 70 && number < 73)
        {
            letter = "C-";
        }
// in this part we can to fine about D

        else if (number >= 67 && number < 70)
        {
            letter = "D+";
        }
        else if (number >= 63 && number < 67)
        {
            letter = "D";
        }
        else if (number >= 60 && number < 63)
        {
            letter = "D-";
        }



        else if (number > 0 && number < 60)
        {
            letter = "F";
        }
        
        else 
        {
            letter = "Sorry, that value is out of range.";
        }

        Console.WriteLine(letter);
    }
}