/*using System;

public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    public override void RecordEvent(GoalManager manager){
        manager.AddScore(GetPoints());
    }

    public override bool IsComplete(){
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation(){
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}

using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent(GoalManager manager)
    {
        manager.AddScore(GetPoints());
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}
*/

using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent(GoalManager manager)
    {
        manager.AddScore(GetPoints());
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}
