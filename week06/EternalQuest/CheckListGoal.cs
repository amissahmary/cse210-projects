using System;

public class CheckListGoal : Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(int target, int bonus,string name, string description, string points) : base(name, description, points){
        _target = target;
        _bonus = bonus;
    }

    public void RecordEvent(){

    }

    public bool IsComplete(){
        return true;
    }

    public string GetDetailsString(){
        return "";
    }

    public string GetStringRepresentation(){
        return "";
    }
}