using System;

public class Comment
{
    public string _userName;

    public string _commentText;


    public void DisplayAllComments()
    {
        Console.WriteLine($"{_userName}: {_commentText}");
    } 
    
   
}