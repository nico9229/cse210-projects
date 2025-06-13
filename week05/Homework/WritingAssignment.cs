using System;
class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentN, string topic, string title): base (studentN, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

}