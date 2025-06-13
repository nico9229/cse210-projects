using System;
class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentN, string topic)
    {
        _studentName = studentN;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return "Name: "+GetStudentName() +", "+"Topic: "+ GetTopic();
    }
}