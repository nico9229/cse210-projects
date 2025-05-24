using System;

class Scripture
{
    private Reference _reference; // Usamos la clase Reference que contiene toda la estructura de variables 
                                  // Esto incluye al metodo que nos retorna la estructura final 
    private List<Word> _words;

    public Scripture(Reference R, string t)
    {
        _reference = R;

        string[] Ws = t.Split(" ");//separamos el texto palabra por palabra 
        _words = new List<Word>();// pienso que aqui creamos una caja para agregar todas las palabras 

        foreach (string i in Ws)
        {
            _words.Add(new Word(i));


        }

    }
    public string GetDisplayText()
    {
        string refText = _reference.GetDisplayText();
        string wdText = "";

        foreach (Word w in _words)
        {
            wdText += w.GetDisplayText() + " ";
        }

        return refText + "\n" + wdText.Trim();
    }

    public void HideRandomWords(int numToHide)
    {
        Random R = new Random();
        int count = 0;

        while (count < numToHide && _words.Exists(w => !w.IsHidden()))
        {
            int index = R.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

      
}