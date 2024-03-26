class Reference
{
    private string _name;
    private string _chapter;
    private string _verse;

    public Reference(string name, string chapter, string verse)
    {
         _name=name;
         _chapter=chapter;
         _verse=verse;
    }

    public void ShowReference()
    {
        Console.Write($"{_name} {_chapter}:{_verse} ");
    }
}