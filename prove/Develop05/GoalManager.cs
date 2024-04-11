class GoalManager
{
    public List<Goals> listGoals = new List<Goals>();
    public int points = 0;
    public GoalManager()
    {

    }

    public void start()
    {
        string inputUser = "";
        while (inputUser != "6")

        {
            Console.WriteLine();
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            inputUser = Console.ReadLine();

            if (inputUser == "1")
            {

                CreateGoal();
            }
            else if (inputUser == "2")
            {
                ListGoalName();
            }

        }
    }

    public void ListGoalName()
    {
        int number = 1;
        foreach (Goals goals in listGoals)
        {
            Console.WriteLine(goals.GetDetailsString());
            Console.WriteLine($"{number}. {goals.GetDetailsString()}");
            number++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal ");
        Console.Write("Wich type of goal would you like to create? ");
        string type = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int amount = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            SimpleGoal simple = new SimpleGoal(name, description, amount);
            listGoals.Add(simple);

        }
        else if (type == "2")
        {
            EternalGoal eternal = new EternalGoal(name, description, amount);
            listGoals.Add(eternal);
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Checklist checkGoal = new Checklist(name, description, amount, 0, target);
            listGoals.Add(checkGoal);
        }


    }
}
