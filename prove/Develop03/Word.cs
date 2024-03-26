class Word
{
    private string _word;
    public Word(string pasaje)
    {
        _word = pasaje;
    }

    public string getWord()
    {
        return _word;
    }
    public void setWord(string word)
    {
        _word=word;

    }


    public void showPasaje()
    {
        Console.Write($"{_word}");
    }
}