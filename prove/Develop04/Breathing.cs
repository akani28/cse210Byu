using System.Data;

class Breathing : Activity
{
    private string descriptionMessages = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public Breathing() : base() { }
    
    public string GetDescription()
    {
        return descriptionMessages;
    }

    public void MessagesBreathing()
    {
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.WriteLine("");
            Console.Write("Breathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.WriteLine("");
            currentTime = DateTime.Now;

        }
       
       



       

    }

}