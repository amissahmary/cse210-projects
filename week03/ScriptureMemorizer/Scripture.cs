using System;
using System.ComponentModel;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        string[] parts = text.Split(" ",StringSplitOptions.RemoveEmptyEntries);

        foreach(string part in parts){
            _words.Add(new Word(part));
        }
    }
    
    public void HideRandomWords(int numberToHide){
        Random random = new Random();
        int hidden = 0;

        while(hidden < numberToHide){
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden()){
                word.Hide();
                hidden++;
            }
            if (IsCompletelyHidden()){
                break;
            }
        }
    }

    public string GetDisplayText(){
        string result = _reference.GetDisplayText() + "";

        foreach(Word word in _words){
            result += word.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletelyHidden(){
        foreach(Word word in _words){
            if(!word.IsHidden()){
                return false;
            }
        }
        return true;
    }

    public string GetReferenceText(){
        return _reference.GetDisplayText();
    }
}