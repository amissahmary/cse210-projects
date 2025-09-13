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
        foreach (Entry text in _entries)
        {
            Console.WriteLine(text.Display());
        }
    }

    public void SaveToFile(string _filename)
    {
        //code goes here
        using(StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry.Display());
            }
        }
    }

    public void LoadFromFile(string _filename)
    {
        //code goes here
        string text = File.ReadAllText(_filename);

        foreach (Entry texts in _entries)
        {
            Console.WriteLine(texts);
        }
    }
}