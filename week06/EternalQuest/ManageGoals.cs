using System;
using System.IO;

public abstract class ManageGoals : Goal
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public ManageGoals(string goalName, string goalDescription, int points, int score) : base(goalName, goalDescription, points)
    {
       
        _score = score;
    }

    public void DisplayPlayerData()
    {
        Console.WriteLine($"{_goalName}\n{_goalDescription}\n{_points}");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour goals:\n");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal}");
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
        int _points = 0;
        string _pointsInTxt = _points.ToString();


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
            Console.Write("Enter the target count");
            int _target = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points:");
            int _extraBonus = int.Parse(Console.ReadLine());

            newGoal = new CheckListGoal(_goalName, _goalDescription, _points, _target, _extraBonus);
        }

        else
        {
            Console.WriteLine("");
            return;
        }

        _goals.Add(newGoal);

    }

    public override void RecordEvent()
    {
        Console.WriteLine("");
    }

    public void SaveGoal()
    {
        Console.WriteLine("Type your file's name: ");
        string filename = Console.ReadLine();

        using (StreamWriter userFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                userFile.WriteLine(goal);
            }
        }

        Console.WriteLine($"Your goals have been saved in {filename} successfully.");

    }

    public void LoadGoal()
    {
        Console.WriteLine("Enter the name of you file to load your goals: ");

        int _score = 0;
        string _scoreGoal = _score.ToString();

        string filename = Console.ReadLine();

        string[] _goalLines = System.IO.File.ReadAllLines(filename);

        
        foreach (string _goalLine in _goalLines)
        {
            string[] _goalLineParts = _goalLine.Split(",");

            string _goalName = _goalLineParts[0];
            string _goalDescription = _goalLineParts[1];
            _scoreGoal = _goalLineParts[2];

        }



    }

}