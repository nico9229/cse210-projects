using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startingAge = 2019;
        job1._endAge = 2022;

        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startingAge = 2022;
        job2._endAge = 2023;

        Resume myResume = new Resume();
        myResume._name = "Nicolas Ayala";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

       myResume.Display();


        
    }
}