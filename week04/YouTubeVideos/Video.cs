using System;
using System.Collections.Generic;
using System.IO;

public class Video
{
    public string _videoTitle;

    public string _videoAuthor;

    public float _videoLength;

    public List<Comment> _comments = new List<Comment>();
    public void StoreVideoComments()
    {
        string filename = Path.Combine(Environment.CurrentDirectory, "../../../../../stored_comments.txt");
        using (StreamWriter file = new StreamWriter(filename, append : true))
        {

            file.WriteLine($"Title: {_videoTitle}");
            file.WriteLine($"By: {_videoAuthor}");
            file.WriteLine($"Length: {_videoLength} minutes");
            file.WriteLine($"Comments");
            foreach (Comment comment in _comments)
            {
                file.WriteLine($"{comment._userName}: {comment._commentText}");
            }

            file.WriteLine("\n-----------------------------\n");
        }
    }


    public void GetNumberComments()
    {
        Console.WriteLine($"Total Comments: {_comments.Count}");
        
    }

    public void DisplayAll()
    {
        Console.WriteLine($"{_videoTitle}");
        Console.WriteLine($"By: {_videoAuthor}");
        Console.WriteLine($"{_videoLength} minutes\n");
        Console.WriteLine($"Comments: ");

        foreach (Comment comment in _comments)
        {
            comment.DisplayAllComments();
            Console.WriteLine();
        }

    }

}