using System;

class Program
{
    
    static void Main(string[] args)
    {
        string dataUser ="";
        Scripture scripture = new Scripture();
        scripture.ShowScripture();
        
        while(dataUser!="quit"){
            Console.Clear();
            scripture.ShowScripture();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            dataUser = Console.ReadLine();
<<<<<<< HEAD
            Console.Clear();
=======
>>>>>>> 7a59514dbea2acd2f6734619ba7406bc4d9b3538
            scripture.replaceWord();
            
           

        }

        
        

    
    }
}