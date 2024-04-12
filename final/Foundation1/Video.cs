class Video
{
    private string _title;
    private string _author;
    private int _duration;
    public List<Comment>commentList = new List<Comment>();
    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;

        
    }

    public string DisplayInfoVideo()
    {
        return $" {_title} author: {_author} duration: {_duration}s.";
    }
}