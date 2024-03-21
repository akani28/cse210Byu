class Entry
{
    DateTime theCurrentTime;
    string dateText;
    
    List<string> entries;
    public Entry()
    {
        theCurrentTime = DateTime.Now;
        entries = new List<string>();

    }
    public void entry(string entryUser, string randomPrompt)
    {
        dateText = theCurrentTime.ToShortDateString();
        string prompt ="Date: "+dateText+$" - Prompt: {randomPrompt}, "+entryUser;
        entries.Add(prompt);
    }
    public void DisplayEntry()
    {
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

}