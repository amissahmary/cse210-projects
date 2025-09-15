using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public void SetBook(string book){
        _book = book;
    }

    public void SetChapter(int chapter){
        _chapter = chapter;
    }

    public void SetVerse(int verse){
        _verse = verse;
    }

    public void SetEndVerse(int endVerse){
        _endVerse = endVerse;
    }

    public string GetBook(){
        return _book;
    }

    public int GetChapter(){
        return _chapter;
    }

    public int GetVerse(){
        return _verse;
    }

    public int GetEndVerse(){
        return _endVerse;
    }

    public string GetDisplayText(){
        if (_endVerse > 0 && _endVerse > _verse){
            return $"{_book} {_chapter} : {_verse} - {_endVerse}   ";
        }
        else{
            return $"{_book} {_chapter} : {_verse}   ";
        }
    }
}