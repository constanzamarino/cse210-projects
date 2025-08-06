using System;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts;

    public Listing(string name, string description, int timeDuration, int count, List<string> prompts) :base(name, description, timeDuration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void RunListingActivity()
    {

    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }



    
}