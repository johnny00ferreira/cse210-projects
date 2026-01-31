using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "I finally understand classes."));
        videos.Add(video1);

        Video video2 = new Video("Object-Oriented Programming", "Tech World", 900);
        video2.AddComment(new Comment("Diana", "This was confusing at first."));
        video2.AddComment(new Comment("Ethan", "Now abstraction makes sense."));
        video2.AddComment(new Comment("Fiona", "Nice examples."));
        videos.Add(video2);

        Video video3 = new Video("C# Foundations", "Programming Hub", 750);
        video3.AddComment(new Comment("George", "Perfect for beginners."));
        video3.AddComment(new Comment("Hannah", "Clear and simple."));
        video3.AddComment(new Comment("Ian", "Loved the explanation."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Duration (seconds): " + video.GetDuration());
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine("-----------------------------------");
        }
    }
}
