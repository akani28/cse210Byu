class Comment
{
    private string _name;
    private string _text;
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;

    }

    public int AmountComment(List<Comment> comments)
    {
        return comments.Count;
    }

    public string DisplayComment()
    {
        return $"{_name} {Environment.NewLine} {_text}.";
    }
}