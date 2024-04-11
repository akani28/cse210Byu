class Checklist : Goals
{
    private int amountCompleted;
    private int _target;
    private int bonus;
    public Checklist(string name, string description, int amount, int target, int bonus) : base(name, description, amount)
    {
        _target = target;

    }
    public override string GetDetailsString()
    {
        return $"[ ] {base.GetName()} ({base.GetDescription()}) -- Currently completed: {bonus = 0}/{_target}";
    }
}