using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video _video1 = new Video("Avator", "Mills", 23);
        Comments com1 = new Comments("Mary", "The movie is ugly.");
        _video1.AddComment(com1);
        Comments com2 = new Comments("May", "I love the song.");
        _video1.AddComment(com2);
        Comments com3 = new Comments("Mar", "It is ugly.");
        _video1.AddComment(com3);
        videos.Add(_video1);

        Video _video2 = new Video("Frozen", "Elsa", 230);
        Comments com11 = new Comments("Anna", "I love you Elsa.");
        _video2.AddComment(com11);
        Comments com22 = new Comments("Sofia", "I love your dress Elsa.");
        _video2.AddComment(com22);
        Comments com33 = new Comments("Ariel", "Can you freeze the entire ocean?");
        _video2.AddComment(com33);
        Comments com44 = new Comments("Ella", "I love the forest.");
        _video2.AddComment(com44);
        videos.Add(_video2);

        Video _video3 = new Video("Wicked", "Ariana Grande", 130);
        Comments com111 = new Comments("Beauty", "I love the pink dress she wore.");
        _video3.AddComment(com111);
        Comments com222 = new Comments("Beast", "Do you want to die?");
        _video3.AddComment(com222);
        Comments com333 = new Comments("Jesus", "God loves you all and so do I.");
        _video3.AddComment(com333);
        Comments com444 = new Comments("Martha", "I love you too Jesus.");
        _video3.AddComment(com444);
        videos.Add(_video3);

        foreach(Video video in videos){
            int index = videos.IndexOf(video);
            Console.WriteLine($"\t\t\t\t\t Video {index + 1}");
            Console.WriteLine(video.Description());
            video.LengthOfComment();
            Console.WriteLine(video.DisplayCommentList());
        }
    }
}