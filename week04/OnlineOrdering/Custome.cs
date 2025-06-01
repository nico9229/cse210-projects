using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address addres)
    {
        _name = name;
        _address = addres;

    }
    public void displayCustomerInfo()
    {
        Console.WriteLine($"customer: {_name}");
        _address.displayAddress();
    }
    public bool isFormUSA()
    {
        return _address.isInUSA();
    }
}