using System;
using System.Collections.Generic;

// Esta es la estructura con la que quiero que mi coleccion se defina o se vea 
public class Shape
{
    public string _prompt2 = "";   //variables que utilizo en el programa principal para almacenar informacion 
    public string _answer = "";
    public string _date = "";
    public void shape()  // mi estructura o plantilla de como quiero que se vea y la utilizo en el programa Journal 
    {
        Console.WriteLine($"{_date} - {_prompt2}");
        Console.WriteLine($"> {_answer}");
        Console.WriteLine();
    }
}