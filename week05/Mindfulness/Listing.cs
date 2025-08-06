using System;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts;

    public Listing(string name, string description, int timeDuration, int count) : base(name, description, timeDuration)
    {
        _prompts = new List<string>();
        _count = count;
    }

    public void RunListingActivity()
    {

    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }



    
}