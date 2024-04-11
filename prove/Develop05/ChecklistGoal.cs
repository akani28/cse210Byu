class Checklist:Goals
{
    private int amountCompleted;
    private int target;
    private int bonus;
    public Checklist(string name, string description, int amount, int target, int bonus): base(name, description, amount)
    {

    }
    public override string GetDetailsString()
    {
        return $"[ ] {base.GetName()} ({base.GetDescription()}) -- Currently completed: {bonus=0}/{target}";
    }
}