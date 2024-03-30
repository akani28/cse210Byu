using System.Reflection.Metadata;

class Scripture
{
    private Reference reference;
    private Word word;

    private Random random = new Random();
    private int numberRandom;

    private int repeatRandom;
    public Scripture()
    {
        //reference = new Reference("3 Nefi", "22", "7");
        reference = new Reference("1 Nefi", "1", "1-2");
        //word = new Word("y todos tus hijos seran instruidos por el señor y grande sera la paz de tus hijos\n");
        word= new Word(" I, Nephi, having been aborn of bgoodly cparents, therefore I was dtaught somewhat in all the learning of my father; and having seen many eafflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a frecord of my proceedings in my days.\n Yea, I make a record in the alanguage of my father, which consists of the learning of the Jews and the language of the Egyptians.");
        foreach (int number in word._listNumberRandom)
        {
            Console.WriteLine("los numeros de la lista: " + number);
        }
        Console.WriteLine(word._listNumberRandom.Count);

    }

    public void ShowScripture()
    {
        reference.ShowReference();
        word.showPasaje();
    }
    public void replaceWord()
    {
        numberRandom = random.Next(word.getWord().Split(" ").Length - 1);//el numero aleatorio no se genera en ocasiones.lo que causa el error
        repeatRandom = numberRandom;
        string[] words = word.getWord().Split(" ");
        Console.WriteLine($"{numberRandom}");
        foreach (string word in words)
        {
            Console.Write($" {word} ");
        }
        string randomWord = words[numberRandom];
        if (randomWord.Contains("_") || repeatRandom == numberRandom)
        {
            numberRandom = random.Next(word.getWord().Split(" ").Length - 1);
            Console.WriteLine(numberRandom);
            //se debe generar otro numero aleatorio y verificar que este no se repita
            string randomWord2 = words[numberRandom];
            string str = new string('_', randomWord2.Length);
            string textword = word.getWord().Replace(randomWord2, str);
            word.setWord(textword);
            ShowScripture();

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