using System;

public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string bookSection, string problems) : base(name, topic){
        _textbookSection = bookSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return $"Section: {_textbookSection}        Problems: {_problems}\n\n";
    }
}