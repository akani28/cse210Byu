class Video
{
    private string _title;
    private string _author;
    private int _duration;
    public List<Comment> commentList = new List<Comment>();
    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;


    }

    public string DisplayInfoVideo()
    {
        return $" {_title} author: {_author} duration: {_duration}s.{Environment.NewLine}";
    }

    public void addComment()
    {
        string inputComment = "yes";
        while (inputComment == "yes")
        {
            Console.Write("Write your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Write your comment ");
            string text = Console.ReadLine();
            Comment comment = new Comment(name, text);
            commentList.Add(comment);
            Console.Write("do you want to add another comment? ");
            inputComment = Console.ReadLine();

        }

    }
    public void ShowComments()
    {
        Console.Write($"video: { _title}");
        foreach (Comment comment in commentList)
        {
            comment.DisplayComment();
            
        }
    }
}