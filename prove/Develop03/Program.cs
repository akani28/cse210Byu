using System;

class Program
{
    
    static void Main(string[] args)
    {
        string dataUser ="";
        Scripture scripture = new Scripture();
        //scripture.ShowScripture();
        
        while(dataUser!="quit"){
            Console.Clear();
            scripture.ShowScripture();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            dataUser = Console.ReadLine();
            ////Console.Clear();
            scripture.replaceWord();
            
           

        }

        
        

    
    }
}