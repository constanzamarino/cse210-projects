using System;

public class MathAssignment : Assignment
{
    private string _textBookSection;

    private string _problems;

    public MathAssignment(string studentName, string topic, string textBooKSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBooKSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} - Problems {_problems}";
    }
}