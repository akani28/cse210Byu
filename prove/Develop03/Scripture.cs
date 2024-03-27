class Scripture
{
    private Reference reference;
    private Word word;

    private Random random = new Random();
    private int numberRandom;
    public Scripture()
    {
        reference = new Reference("3 Nefi", "22", "7");
        word = new Word("y todos tus hijos seran instruidos por el señor y grande sera la paz de tus hijos \n");


    }

    public void ShowScripture()
    {
        reference.ShowReference();
        word.showPasaje();
    }
    public void replaceWord()
    {
        numberRandom = random.Next(0, word.getWord().Split().Length + 1);//el numero aleatorio no se genera en ocasiones.lo que causa el error
        string[] words = word.getWord().Split(" ");
        Console.WriteLine($"{numberRandom}");
        foreach (string word in words)
        {
         Console.Write($" {word} ");
        }
        string randomWord = words[numberRandom];
        if (randomWord.Contains("_"))
        {

        }
        else
        {
            Console.WriteLine("the randomWord is " + words[numberRandom]);
            string str = new string('_', randomWord.Length);
            string textword = word.getWord().Replace(randomWord, str);
            word.setWord(textword);
            ShowScripture();

        }


        //foreach (string word in words)
        //{
        // Console.Write($"{word}");
        //}

    }


}