using System;
using System.Collections.Generic;

public class Video
{
    public string _videoTitle;

    public string _videoAuthor;

    public float _videoLength;

    public List<Comment> _comments = new List<Comment>();

    public void StoreVideoComments()
    {
        string filename = "stored_comments.txt";
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Comment comment in _comments)
            {
                file.WriteLine($"{_videoLength}\n{_videoTitle}\nBy:{_videoAuthor}\n{comment}");
            }
        }
    }

    public void GetNumberComments()
    {
        foreach (Comment comment in _comments)
        {
            int _numberComments = _comments.Count;
            Console.WriteLine($" Comments: {_numberComments}");
        }
    }

    public void DisplayAll()
    {
        
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{_videoLength}\n{_videoTitle}\nBy:{_videoAuthor}\n{comment}");
        }
        
    }


}