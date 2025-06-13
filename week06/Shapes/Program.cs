using System;
using System.Collections.Generic;
public abstract class Shape
{
    private String _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();

    public abstract void GetName();

}


// hasa aqui tengo mi clase hija que hereda los parametros del constructor 
// tambien tengo un metodo del tipo Shape pero que tiene su porpio comportamiento 
public class Square : Shape
{
    double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
    public override void GetName()
    {
        Console.WriteLine("I am a Square");
    }
}


public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }
    public override double GetArea()
    {
        return _width * _height;
    }

    public override void GetName()
    {
        Console.WriteLine("I am a Rectangle");
    }
}

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radiud) : base(color)
    {
        _radius = radiud;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
    public override void GetName()
    {
        Console.WriteLine("I am a Circle");
    }
}
// clases hijos:  Square, Rectangle, Circle 
class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();

        list.Add(new Square("red", 12));
        list.Add(new Rectangle("green", 5, 10));
        list.Add(new Circle("blue", 6));

        foreach (Shape i in list)
        {
            Console.WriteLine("");
            i.GetName();
            Console.WriteLine($"Shape color: {i.GetColor()}");
            Console.WriteLine($"Area: {i.GetArea()}");           
            Console.WriteLine($"-----------------");
        }
    }
}