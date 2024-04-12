class Comment
{
    private string _name;
    private string _text;
    public Comment(string name, string text)
    {

    }

    public int AmountComment(List<Comment> comments)
    {
        return comments.Count;
    }
}