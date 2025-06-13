using System;

class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;


    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"Product: {_name}");
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Quantity: {_quantity}");

    }
    public double getPrice()
    {
        return _price;
    }

    public string getName()
    {
        return _name;
    }
    public int getId()
    {
        return _id;
    }
    public int getQuantity()
    {
        return _quantity;
    }

    
}
