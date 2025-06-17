using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.Win32.SafeHandles;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public void Start()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("  Eternal Quest Menu");
            Console.WriteLine("======================");
            Console.WriteLine("");
            Console.WriteLine("1. Show Goals");
            Console.WriteLine("2. Create new goal");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Exit");
            Console.Write("Chose an option > ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                ListGoalDetails();
            }
            else if (input == "2")
            {
                CreateGoal();
            }
            else if (input == "3")
            {
                RecordEvent();
            }
            else if (input == "4")
            {
                SaveGoals();
            }
            else if (input == "5")
            {
                LoadGoals();
            }
            else if (input == "6")
            {
                DisplayPlayerInfo();
            }
            else if (input == "7")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again");
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? >");

        string choice = Console.ReadLine();

        Console.Write("What is the name of your goals? >");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? >");
        string description = Console.ReadLine();

        Console.Write("What is the amount of point associated with this goal? >");
        int point = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, point);
            _goals.Add(goal);
        }
        else if (choice == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, point);
            _goals.Add(goal);
        }
        else if (choice == "3")
        {
            Console.Write("How many time does this goal need to be accomplished for a bonus? >");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many time? >");
            int bonus = int.Parse(Console.ReadLine());

            CheckListGoal goal = new CheckListGoal(name, description, point, target, bonus);
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\n You have {_score} point. \n");
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:\n");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been added yet. \n");
        }
        else
        {
            int index = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{index}. {goal.GetDetailsString()}");
                index++;
            }
            Console.WriteLine();
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nThere are no goals to record. Please create one first \n");
            return;
        }
        Console.WriteLine("\nWhich goal did you accomplish?\n");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        Console.Write("\nEnter the number of the goal: ");
        string input = Console.ReadLine();
        int index;

        if (int.TryParse(input, out index) && index >= 1 && index <= _goals.Count)
        {
            Goal selectedGoal = _goals[index - 1];
            int points = selectedGoal.RecordEvent();
            _score += points;
            Console.WriteLine($"\nYou earned {points} points!");
            Console.WriteLine($"Total score: {_score}\n");
        }
        else
        {
            Console.WriteLine("\nInvalid input. Please try again.\n");
        }
    }
    public void SaveGoals()
    {

        Console.Write("\nEnter a filanme to save your goals >");
        string text = ".txt";
        string name = Console.ReadLine();
        string filename = name + text;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);  

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("\nGoals saved successfully!\n");

    }
    public void LoadGoals()
    {
        Console.Write("\nEnter the filename to load your goals from: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);  

            _goals.Clear(); 

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string goalType = parts[0];
                string[] data = parts[1].Split(",");

                if (goalType == "SimpleGoal")
                {
                    string name = data[0];
                    string description = data[1];
                    int points = int.Parse(data[2]);
                    bool isComplete = bool.Parse(data[3]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    goal.SetComplete(isComplete);
                    _goals.Add(goal);
                }
                else if (goalType == "EternalGoal")
                {
                    string name = data[0];
                    string description = data[1];
                    int points = int.Parse(data[2]);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string name = data[0];
                    string description = data[1];
                    int points = int.Parse(data[2]);
                    int target = int.Parse(data[3]);
                    int bonus = int.Parse(data[4]);
                    int amountCompleted = int.Parse(data[5]);

                    CheckListGoal goal = new CheckListGoal(name, description, points, target, bonus);
                    goal.SetAmountCompleted(amountCompleted);
                    _goals.Add(goal);
                }
            }

            Console.WriteLine("\nGoals loaded successfully!\n");
        }
        else
        {
            Console.WriteLine("\nFile not found.\n");
        }

    }
    public void AddGoal(Goal g)
    {
        _goals.Add(g);
    }
    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals: ");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;

        }
    }
    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
            Console.WriteLine($"Total point: {_score}");
        }
    }   

}