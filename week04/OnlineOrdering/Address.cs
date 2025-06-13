using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public void displayAddress()
    {
        Console.WriteLine($"Street: {_street}");
        Console.WriteLine($"City: {_city}");
        Console.WriteLine($"State: {_state}");
        Console.WriteLine($"Country: {_country}");
    }

    public bool isInUSA()
    {
        return _country.ToLower() == "usa";
    }
}