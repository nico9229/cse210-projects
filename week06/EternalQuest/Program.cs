using System;
using System.Collections.Generic;

interface Sonido
{
    void HaceUnSonido();
}

interface Movimiento
{
    void HaceUnMovimiento();
}

class Animal
{
    private string _name;
    private string _raza;

    public Animal(string n, string r)
    {
        _name = n;
        _raza = r;
    }

    public string GetNombre()
    {
        return _name;
    }
    public string GetRaza()
    { 
        return _raza;
    }
}

class Perro : Animal, Sonido, Movimiento
{
    public Perro(string nombre, string raza) : base(nombre, raza)
    {

    }

    public void HaceUnSonido()
    {
        Console.WriteLine($"el perro de raza: {GetRaza()} llamado: {GetNombre()}");
        Console.WriteLine("le gusta ladrar");
    }
    public void HaceUnMovimiento()
    {
        Console.WriteLine($"A {GetNombre()}, le gusta jugar con su hueso ");
    }
}

class Gato : Animal, Sonido, Movimiento
{
    public Gato(string nombre, string raza) : base(nombre, raza)
    {

    }
    public void HaceUnSonido()
    {
        Console.WriteLine($"el gato de raza: {GetRaza()} llamado: {GetNombre()}");
        Console.WriteLine("le gusta maullar");
    }
    public void HaceUnMovimiento()
    {
        Console.WriteLine($"A {GetNombre()}, le gusta jugar con otros gatos ");
    }
}

class Program
{
    //interface Sonido y movimiento 
    // clase base animal que hereda 2 parametros: nombre y raza
    // clase gato y perro que eredan los constructores
    // y tambien las interface forzan a heredar sus metodos
    static void Main(string[] args)
    {
        List<Sonido> sonido = new List<Sonido>();
        List<Movimiento> movimiento = new List<Movimiento>();

        Perro p = new Perro("Rooney", "Ratonero");
        Gato g = new Gato("Garfiel", "Naranja");


        sonido.Add(p);
        sonido.Add(g);

        movimiento.Add(p);
        movimiento.Add(g);

        Console.WriteLine("\n----------------");
        Console.WriteLine("Lista de sonido");
        Console.WriteLine("----------------");
        foreach (Sonido s in sonido)
        {
            s.HaceUnSonido();
        }
        Console.WriteLine("\n----------------");
        Console.WriteLine("Lista de movimiento");
        Console.WriteLine("----------------");
        foreach (Movimiento s in movimiento)
        {
            s.HaceUnMovimiento();
        }
        
    }
}