using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Video> videos = new List<Video>();

        // Creating videos
        Video video1 = new Video("C# Basics", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        Video video2 = new Video("Advanced C#", "Jane Smith", 1200);
        video2.AddComment(new Comment("Dave", "This was very informative."));
        video2.AddComment(new Comment("Eve", "Can you make more on this topic?"));
        video2.AddComment(new Comment("Frank", "Superb content!"));

        Video video3 = new Video("C# Design Patterns", "Mike Johnson", 900);
        video3.AddComment(new Comment("Grace", "Loved the examples!"));
        video3.AddComment(new Comment("Hannah", "Clear and concise."));
        video3.AddComment(new Comment("Ian", "Thank you for this!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Displaying information about each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
        