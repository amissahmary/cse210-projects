using System;
using System.IO;

public class Journal 
{
    public string _filename;
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        //code goes here
        _entries.Add(entry);
    }

    public void Display()
    {
        //code goes here
        foreach (text in _entries)
        {
            Console.WriteLine(text);
        }
    }

    public void SaveToFile(string _filename)
    {
        //code goes here
    }

    public void LoadFRomFile(string _filename)
    {
        //code goes here
    }
}