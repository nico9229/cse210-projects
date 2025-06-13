using System;


class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    public Reference(string B, int Ch, int v)
    {
        _book = B;
        _chapter = Ch;
        _verse = v;
        _endverse = v;
    }

    public Reference(string B, int Ch, int v, int endV)
    {
        _book = B;
        _chapter = Ch;
        _verse = v;
        _endverse = endV;
    }

    public string GetDisplayText()
    {
        if (_verse == _endverse) // si se introduce solo un versiculo automaticamente
        {                        // _endverse tendra el mismo numero, y eso activara la primer a condicion 
            return $"{_book} {_chapter}:{_verse}"; // y no es posible que introduscas 2 versiculos iguales 
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endverse}";
        }
    }
}