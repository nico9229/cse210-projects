using System;
class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string tx, string pms, string studentN, string topic) : base(studentN, topic)
    {
        _textbookSection = tx;
        _problems = pms;
    }
    public string GetText()
    {
        return _textbookSection;
    }
    public string GetProb()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;   
    }
}