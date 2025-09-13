using System;
using System.IO;
using System.Text.Json;

public class Entry
{
    public string _date{get; set;}
    public string _promptText{get; set;}
    public string _entryText{get; set;}

    public string Display()
    {
        //code goes here
        string _entry = $"Date: {_date}  \nPrompt: {_promptText} \nResponse: {_entryText}";
        return _entry;
    }
}