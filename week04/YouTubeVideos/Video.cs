using System;

class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _Cs = new List<Comment>();

    public Video(string T, string A, int D)
    {
        _title = T;
        _author = A;
        _duration = D;
    }

    public void displayVideo()
    {
        Console.WriteLine("OUR VIDEOSSSS");
        Console.WriteLine("-------------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_duration}");
        Console.WriteLine("\n");
    }

    public void setComent(Comment C)
    {
        _Cs.Add(C);
    }

    public void displayComment()
    {
        foreach (Comment i in _Cs)
        {
            i.setComment();
        }
    }


}