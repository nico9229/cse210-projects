using System;
using System.Collections.Generic;


public class Entry
{

    public List<string> _prompt = new List<string>()                    // mi lista de preguntas aleaotrias que la utilizo en el programa principal 
    {                                                                   // - pero esta lista pasa por un metodo para que se pase de forma aleaotria
        "Who was the most interesting person I interacted with today?",  
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string promtGenerator()
    { 
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }

}