class Word
{
    private string _word;
    public List<int> _listNumberRandom;
    private Random r = new Random();
    private int numRandom;
    private int acumulator = 0;
    private int counter = 0;
    public Word(string pasaje)
    {
        _word = pasaje;
        _listNumberRandom = new List<int>();
        AddNumberRandom();
    }

    public string getWord()
    {
        return _word;
    }
    public void setWord(string word)
    {
        _word = word;

    }
    public void showPasaje()
    {
        Console.Write($"{_word}");
    }

    private void AddNumberRandom()
    { 
        while (counter < _word.Length)
        {
            numRandom = r.Next(_word.Split("  ").Length - 1);
            if (numRandom == acumulator)
            {
                Console.WriteLine("valores de la lista: "+numRandom);

            }
            else
            {
                _listNumberRandom.Add(numRandom);
                acumulator = numRandom;
            }
            counter++;
        }


    }
}