using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video { _videoLength = 0, _videoTitle = "", _videoAuthor = "" };
        video1._comments.Add(new Comment { _userName = "", _commentText = "" });
        video1._comments.Add(new Comment { _userName = "", _commentText = "" });
        video1._comments.Add(new Comment { _userName = "", _commentText = "" });


        Video video2 = new Video { _videoLength = 0, _videoTitle = "", _videoAuthor = "" };
        video2._comments.Add(new Comment {_userName = "", _commentText = "" });
        video2._comments.Add(new Comment {_userName = "", _commentText = "" });
        video2._comments.Add(new Comment {_userName = "", _commentText = "" });

        Video video3 = new Video { _videoLength = 0, _videoTitle = "", _videoAuthor = "" };
        video3._comments.Add(new Comment {_userName = "", _commentText = "" });
        video3._comments.Add(new Comment {_userName = "", _commentText = ""});
        video3._comments.Add(new Comment {_userName = "", _commentText = "" });

        Video video4 = new Video {_videoLength = 0, _videoTitle = "", _videoAuthor = "" };
        video4._comments.Add(new Comment {_userName = "", _commentText = "" });
        video4._comments.Add(new Comment {_userName = "", _commentText = "" });
        video4._comments.Add(new Comment {_userName = "", _commentText = ""});

        // I have to connect the methods with the objects through dots somehow.
        // Add info into each attribute in the objects.




    }
}