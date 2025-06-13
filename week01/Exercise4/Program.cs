using System;
using System.Collections.Generic;


class Program

{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string input; 
        int input2;
        int sum = 0;
        float average = 0;


        
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.WriteLine("Enter number: ");
            input = Console.ReadLine();
            input2 = int.Parse(input);

            if (input2 != 0 ) 
            {      
                Console.WriteLine($"Added the number {input2}");
                numbers.Add(input2);
            }
        }

        while (input2 != 0);

            for (int i = 0; i < numbers.Count; i++ )
            { 
                    sum += numbers[i];
            }

            average =  (float)sum / numbers.Count;


            int max = numbers [0];

            foreach (int M in numbers)
            {
                if(M > max)
                {
                    max = M;
                }
            }
                    
            

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average} ");
            Console.WriteLine($"The largest number is: {max}");
    }

}