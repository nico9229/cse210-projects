using System;

class Comment
{
    private string _name;
    private string _comment;

    public Comment(string N, string C)
    {
        _name = N;
        _comment = C;
    }
    public void setComment()
    {
        Console.WriteLine("\n___________________________");
        Console.WriteLine("COMMENT");
        Console.WriteLine("----------------");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_comment}");
        Console.WriteLine("\n___________________________");
    }


}