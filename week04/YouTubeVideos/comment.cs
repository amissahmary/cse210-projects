using System;
using System.Collections.Generic;

public class Comments{
    private string _name;
    private string _text;

    public Comments(string name, string text){
        _name = name;
        _text = text;
    }

    public string TrackComments()
    {
        return $"Commenter: {_name} \nComment: {_text}\n";
    }
}