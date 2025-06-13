using System;


class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customers;

    public Order(Customer customer)
    {
        _customers = customer;

    }
    public void addProdcu(Product product)
    {
        _product.Add(product);
    }
    public void displayOrder()
    {
        _customers.displayCustomerInfo();
        foreach (Product p in _product)
        {
            Console.WriteLine($"Product: {p.getName()}  - ID: {p.getId()}");
        }
    }

    public double calculateTotal()
    {
        double total = 0;
        foreach (Product p in _product)
        {
            total += p.getPrice() * p.getQuantity();
        }

        if (_customers.isFormUSA())
        {
            total += 5.0; 
        }
        else
        {
            total += 35.0; 
        }

        return total;
    }
    public int getTotalQuantity()
    {
        int total = 0;
        foreach (Product p in _product)
        {
            total += p.getQuantity();
        }
        return total;
    }
}