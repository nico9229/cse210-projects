using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

public class Journal
{
    public string _Name;
    List<Shape> _adding = new List<Shape>();  // lista que usa una plantilla del programa shape y guardo la entrada del usuario 

    public void AddEntry(Shape input)
    {
        _adding.Add(input);                 // y lo adiero a esta variable para poder usarala con el metod DisplayAll()
    }

    public void DisplayAll()
    {
        foreach (Shape S in _adding)     // Itero atravez de de la lista _adding y muestro la plantilla de shape pero con los datos del usuario 
        {
            S.shape(); 
        }
    }

    public void SaveToFile(string name)
    {
        using (StreamWriter w = new StreamWriter(name))
        {
            foreach(Shape t in _adding)
            {
                w.WriteLine($"{t._date}|{t._prompt2}|{t._answer}");
            }
        }
    }

    public void LoadFile(string title)
    {
        while (!File.Exists(title))
        {
            Console.WriteLine("That file does not exist. Try again:");
            title = Console.ReadLine() + ".txt";
        }
        string[] lines = File.ReadAllLines(title);

        foreach (string L in lines)
        {
            string[] parts = L.Split('|');

            Shape s = new Shape();
            
            s._date = parts[0];
            s._prompt2 = parts[1];
            s._answer = parts[2];

            _adding.Add(s);

        }
    }
}