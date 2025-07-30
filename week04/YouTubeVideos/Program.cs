using System;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video { _videoLength = 0, _videoTitle = "How To Draw A Face From Different Angles || Beginner Friendly", _videoAuthor = "Da Vinci_XXI" };
        Comment comment1 = new Comment { _userName = "@sketchqueen22", _commentText = "Just what I needed! Tsm for the tutorial, it was very clear :)" };
        Comment comment2 = new Comment { _userName = "@johnnyK75", _commentText = "Bro, I suck at drawing LOL. Sick video tho. New suscriber!" };
        Comment comment3 = new Comment { _userName = "@blendyboi4", _commentText = "Awesome vid, man! Any chance you could drop a hands drawing tutorial next? " };

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        Video video2 = new Video { _videoLength = 0, _videoTitle = "The Legend of Zelda - Full Game Walkthrough (No Commentary)", _videoAuthor = "RetroPlayer57" };
        Comment comment4 = new Comment { _userName = "@link86", _commentText = "Gotta love this! I used to play Zelda back in the 80s. Good ol' days definitely" };
        Comment comment5 = new Comment { _userName = "@pixellady1", _commentText = "Dude, you're a pro at this. Enjoyed your walkthrough!" };
        Comment comment6 = new Comment { _userName = "@mario_luigi12", _commentText = "Cool vid as always. Hope you play Super Mario 64 next time ;)" };

        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        Video video3 = new Video { _videoLength = 0, _videoTitle = "The Inventor of Bypass Surgery Who Revolutionized Medicine Forever! - The Story & Legacy of Dr. René Favaloro", _videoAuthor = "Revolutionary Biographies" };
        Comment comment7 = new Comment { _userName = "@isabellarodriguez51", _commentText = "What a humble and smart man was him! We all love him here in Argentina. Great biography!" };
        Comment comment8 = new Comment { _userName = "@felimartinez_029", _commentText = "Medecine student in Argentina. He's literally a legend around here. R.I.P Dr.Favaloro" };

        Comment comment9 = new Comment { _userName = "@nottijavier03", _commentText = "He inspired me to become a heart surgeon! he was so ahead of his time! Thx for the biography. Greetings from Argentina!" };

        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);

        DisplayAndStoreVideo(video1);
        DisplayAndStoreVideo(video2);
        DisplayAndStoreVideo(video3);

    }

    static void DisplayAndStoreVideo(Video video)
    {
        video.StoreVideoComments();
        video.GetNumberComments();
        video.DisplayAll();
        Console.WriteLine("\n-----------------------------\n");

    }
}