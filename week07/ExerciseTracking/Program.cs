using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> lista = new List<Activity>();

        lista.Add(new Runing(10, "Lunes", 20));
        lista.Add(new Swiming(5, "Martes", 20));
        lista.Add(new Cycling(20, "miercoles", 40));

        foreach (Activity i in lista)
        {
            i.GetSummary();
        }
       
    }
}