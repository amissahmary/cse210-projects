using System;
using System.IO;
using System.Text.Json;

public class Journal 
{
    public string _filename{get; set; }
    public List<Entry> _entries = new List<Entry>();
    public int _index;

    public void AddEntry(Entry entry)
    {
        //code goes here
        _entries.Add(entry);
    }

    public void Display()
    {
        //code goes here
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal yet.");
        }

        foreach (Entry text in _entries)
        {
            Console.WriteLine(text.Display());
            Console.WriteLine(); 
        }
    }

    public void SaveToFile(string _filename)
    {
        //code goes here
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filename, json);
        Console.WriteLine($"Saved {_entries.Count} entries to {_filename}.");

        /*using(StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry.Display());
            }
        }*/
    }

    public void LoadFromFile(string _filename)
    {
        //code goes here
        /*string text = File.ReadAllText(_filename);

        foreach (Entry texts in _entries)
        {
            Console.WriteLine(texts);
        }*/
        if (!File.Exists(_filename))
        {
            Console.WriteLine($"File '{_filename}' not found.");
            return;
        }

        string json = File.ReadAllText(_filename);
        _entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();
        Console.WriteLine($"Loaded {_entries.Count} entries from {_filename}.");
    
    }

    public void EditEntry(int _index)
    {
        if(_index >= 0 && _index < _entries.Count)
        {
            Console.WriteLine("Previous entry: ");
            Console.WriteLine(_entries[_index].Display());

            Console.Write("Enter new response: ");
            string newResponse = Console.ReadLine();

            _entries[_index]._entryText = newResponse;

            Console.WriteLine("Entry updated");
        }
        else
        {
            Console.WriteLine("Entry does not exist.");
        }
    }

    public void DeleteEntry(int _index)
    {
        if(_index >= 0 && _index < _entries.Count)
        {
            _entries.RemoveAt(_index);
            Console.WriteLine("Entry deleted");
        }
        else
        {
            Console.WriteLine("Entry does not exist.");
        }
    }
}