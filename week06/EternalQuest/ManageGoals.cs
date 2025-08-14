using System;
using System.IO;
using System.Collections.Generic;

public class ManageGoals 
{
    private List<Goal> _goals = new List<Goal>();
    public int _score;

    public ManageGoals() 
    {

        _score = 0;
    }

    public void DisplayPlayerData()
    {
        Console.WriteLine($"Total score: {_score}");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour goals:\n");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals entered yet");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_goals[i].GetDetails()}");
        }
    }

    public void AddGoal()
    {
        Console.WriteLine("What type of goal do you want to add?\n1.Simple goal\n2.Eternal goal\n3.Checklist goal");
        int userchoice2 = int.Parse(Console.ReadLine());


        Console.Write("\nEnter your goal name: ");
        string _goalName = Console.ReadLine();

        Console.Write("Enter a short description of your goal: ");
        string _goalDescription = Console.ReadLine();

        Console.Write("Enter the points you will earn if you complete it: ");
        int _points = int.Parse(Console.ReadLine());
       


        Goal newGoal = null;

        if (userchoice2 == 1)
        {

            newGoal = new SimpleGoal(_goalName, _goalDescription, _points);

        }
        else if (userchoice2 == 2)
        {
            newGoal = new EternalGoal(_goalName, _goalDescription, _points);
        }

        else if (userchoice2 == 3)
        {
            Console.Write("Enter the target count: ");
            int _target = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points:");
            int _extraBonus = int.Parse(Console.ReadLine());

            newGoal = new CheckListGoal(_goalName, _goalDescription, _points, _target, _extraBonus);
        }

        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        _goals.Add(newGoal);

    }

    public void RecordEvent()
    {
        Console.WriteLine("Your goals:");
        ListGoals();
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            selectedGoal.RecordEvent();

            _score += selectedGoal._points;

            if (selectedGoal is CheckListGoal checklist && checklist.IsGoalCompleted())
            {
                _score += checklist.GetBouns();
            }

            Console.WriteLine("Event recorded!");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

    }

    public void SaveGoal()
    {
        Console.WriteLine("Type your file's name: ");
        string filename = Console.ReadLine();

        using (StreamWriter userFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                userFile.WriteLine(goal.GetRepresentation());
            }
        }

        Console.WriteLine($"Your goals have been saved in {filename} successfully.");

    }

    public void LoadGoal()

    {

        Console.WriteLine("Enter the name of you file to load your goals: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] _goalLines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(_goalLines[0]);
        _goals.Clear();


        for (int i = 1; i < _goalLines.Length; i++)
        {
            string[] _goalLineParts = _goalLines[i].Split(",");

            string _type = _goalLineParts[0];
            string _goalName = _goalLineParts[1];
            string _goalDescription = _goalLineParts[2];
            int _points = int.Parse(_goalLines[3]);

            if (_type == "Simple Goal")
            {
                bool completed = bool.Parse(_goalLineParts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(_goalName, _goalDescription, _points);

                if (completed)
                {
                    simpleGoal.RecordEvent();
                }
                _goals.Add(simpleGoal);


            }
            else if (_type == "Eternal Goal")
            {

                _goals.Add(new EternalGoal(_goalName, _goalDescription, _points));
            }
            else if (_type == "CheckList Goal")
            {
                int _target = int.Parse(_goalLineParts[4]);
                int _extraBonus = int.Parse(_goalLineParts[5]);
                int _completedCount = int.Parse(_goalLineParts[6]);

                CheckListGoal checkListGoal = new CheckListGoal(_goalName, _goalDescription, _points, _target, _extraBonus);
                for (int c = 0; c < _completedCount; c++)
                {
                    checkListGoal.RecordEvent();
                }
                _goals.Add(checkListGoal);

            }

            Console.WriteLine("Your goals have been loaded successfully!");
        }

    }

}