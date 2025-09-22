using System;
using System.Collections.Generic;

public class Video{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comments> _comments = new List<Comments>();

    public Video(string title, string author, int duration){
        _title = title;
        _author = author;
        _duration = duration;
    }

    public string Description(){
        return $"Title: {_title} \nAuthor: {_author} \nDuration: {_duration} seconds.\n";
    }

    public void AddComment(Comments comment){
        _comments.Add(comment);
    }

    public string DisplayCommentList(){
        string result = "";
        foreach (Comments comment in _comments){
            result += comment.TrackComments() + "\n";
        }
        return result;
    }

    public void LengthOfComment(){
        Console.WriteLine($"This video has {_comments.Count} comments.");
    }
}