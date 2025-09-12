using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display()
    {
        //code goes here
        string _entry = "Date: {_date}  \nPrompt: {_promptText} \nResponse: {_entryText}";
        return _entry;
    }
}