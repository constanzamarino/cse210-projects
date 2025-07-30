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


        Video video2 = new Video { };
        video2._comments.Add(new Comment { });
        video2._comments.Add(new Comment { });
        video2._comments.Add(new Comment { });

        Video video3 = new Video { };
        video3._comments.Add(new Comment { });
        video3._comments.Add(new Comment { });
        video3._comments.Add(new Comment { });

        Video video4 = new Video { };
        video4._comments.Add(new Comment { });
        video4._comments.Add(new Comment { });
        video4._comments.Add(new Comment { });

        // I have to connect the methods with the objects through dots somehow.




    }
}