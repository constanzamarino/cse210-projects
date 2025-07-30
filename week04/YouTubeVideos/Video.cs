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
        string filename = "stored_comments.txt";
        using (StreamWriter file = new StreamWriter(filename, append : true))
        {

            file.WriteLine($"{_videoTitle}");
            file.WriteLine($"{_videoAuthor}");
            file.WriteLine($"{_videoLength}");
            file.WriteLine($"Comments");
            foreach (Comment comment in _comments)
            {
                file.WriteLine($"{comment._userName}: {comment._commentText}");
            }

            file.WriteLine();
        }
    }


    public void GetNumberComments()
    {
        int numberComments = _comments.Count;
        Console.WriteLine($"{numberComments} comments:");
        
    }

    public void DisplayAll()
    {
        Console.WriteLine($"{_videoTitle}");
        Console.WriteLine($"{_videoAuthor}");
        Console.WriteLine($"{_videoLength} minutes");
       

        foreach (Comment comment in _comments)
        {
            comment.DisplayAllComments();
        }

    }

}