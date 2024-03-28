using System;

class Program
{
    
    static void Main(string[] args)
    {
        string dataUser ="";
        Scripture scripture = new Scripture();
        Console.WriteLine("Hello Develop03 World!");
        scripture.ShowScripture();
        
        while(dataUser!="quit"){
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            dataUser = Console.ReadLine();
            Console.Clear();
            scripture.replaceWord();
           

        }

        
        

    
    }
}