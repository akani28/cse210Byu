class Breathing:Activity
{
    private string descriptionMessages="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
    public Breathing(string messages, int pause, string endMessage):base(messages,pause,endMessage)
    {
        

    }
    public Breathing():base(){}
    public void Description()
    {
        Console.WriteLine(descriptionMessages);
    }

}