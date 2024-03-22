

class Program
{
    static void Main(string[] args)
    {
        int flag = 1;
        PromptGenerator promp;
        Entry entry = new Entry();
        Journal journal;
        Console.WriteLine("Welcome to the journal program!");
        while (flag != 5)
        {
            Console.Write("Please select one of the following choices:" + Environment.NewLine +
       "1. Write" + Environment.NewLine +
       "2. Display" + Environment.NewLine +
       "3. Load" + Environment.NewLine +
       "4. Save" + Environment.NewLine +
       "5. Quit" + Environment.NewLine +
       "What would you like to do? ");
            flag = int.Parse(Console.ReadLine());
            if (flag == 1)
            {
                promp = new PromptGenerator();
                string word = promp.promptQuestionRandom2();
                Console.WriteLine(word);
                string writeUser = Console.ReadLine();
                entry.entry(writeUser, word);

            }
            else if (flag == 2)
            {
                entry.DisplayEntry();
            }
            else if (flag == 4)
            {
                Console.WriteLine("What is the filename? ");
                string nameFile = Console.ReadLine();
                journal = new Journal(nameFile);  
                foreach (string userEntry in entry.entries)
                {
                    
                    journal.file(nameFile, userEntry);
                }
            }
            else if(flag==3)
            {
                Console.WriteLine("What is the filename? ");
                string nameFile = Console.ReadLine();
                journal = new Journal(nameFile); 
                journal.readFile(nameFile);

            }

        }



    }
}