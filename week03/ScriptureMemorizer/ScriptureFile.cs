using System;
using System.Collections.Generic;

public class ScriptureFile{
    private List<Scripture> _scriptures = new List<Scripture>();

    public void AddScripture(Scripture scripture){
       _scriptures.Add(scripture);
    }

    public void DisplayAllScriptures(){
        if(_scriptures.Count == 0){
            Console.WriteLine("No scriptures saved yet.");
        }

        for (int i = 0; i < _scriptures.Count; i++){
            Console.WriteLine($"{i + 1}. {_scriptures[i].GetReferenceText()}");
        }
    }

    public Scripture SelectScripture(int index) {
        if (index >= 0 && index < _scriptures.Count){
            return _scriptures[index];
        }
        else{
            Console.WriteLine("Invalid selection");
            return null;
        }
    }

    public void DeleteScripture(int index){
        if (index >= 0 && index <= _scriptures.Count){
            _scriptures.RemoveAt(index);
            Console.WriteLine("Scripture removed from the list.");
        }
        else{
            Console.WriteLine("Inavalid index.");
        }
    }
}