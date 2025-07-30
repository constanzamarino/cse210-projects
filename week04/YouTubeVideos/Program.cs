using System;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video { _videoLength = 0, _videoTitle = "", _videoAuthor = "" };
        Comment comment1 = new Comment();
        comment1._userName = "";
        comment1._commentText = "";

        Comment comment2 = new Comment();
        comment2._userName = "";
        comment2._commentText = "";

        Comment comment3 = new Comment();
        comment3._userName = "";
        comment3._commentText = "";

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        Video video2 = new Video { _videoLength = 0, _videoTitle = "", _videoAuthor = "" };
        Comment comment4 = new Comment();
        comment4._userName = "";
        comment4._commentText = "";

        Comment comment5 = new Comment();
        comment5._userName = "";
        comment5._commentText = "";

        Comment comment6 = new Comment();
        comment6._userName = "";
        comment6._commentText = "";


        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);


        Video video3 = new Video { _videoLength = 0, _videoTitle = "", _videoAuthor = "" };
        Comment comment7 = new Comment();
        comment7._userName = "";
        comment7._commentText = "";

        Comment comment8 = new Comment();
        comment8._userName = "";
        comment8._commentText = "";

        Comment comment9 = new Comment();
        comment9._userName = "";
        comment9._commentText = "";


        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);



        video1.StoreVideoComments();
        video1.GetNumberComments();
        video1.DisplayAll();
        comment1.DisplayAllComments();
        comment2.DisplayAllComments();
        comment3.DisplayAllComments();



        video2.StoreVideoComments();
        video2.GetNumberComments();
        video2.DisplayAll();
        comment4.DisplayAllComments();
        comment5.DisplayAllComments();
        comment6.DisplayAllComments();


        video3.StoreVideoComments();
        video3.GetNumberComments();
        video3.DisplayAll();
        comment7.DisplayAllComments();
        comment8.DisplayAllComments();
        comment9.DisplayAllComments();  

    }
}