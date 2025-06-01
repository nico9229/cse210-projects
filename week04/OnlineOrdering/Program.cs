using System;

class Program
{
    static void Main(string[] args)
    {
        Address addres = new Address("1234", "Presidencia Roque", "Chaco", "ARG");
        Customer customer = new Customer("Nicolas Ayala", addres);

        Product arina = new Product("Arina", 123, 1.7, 10);
        Product azucar = new Product("Azucar", 12, 3.7, 12);

        Order order = new Order(customer);
        order.addProdcu(arina);
        order.addProdcu(azucar);

        order.displayOrder();
        Console.WriteLine($"Total order cost: ${order.calculateTotal()}");

    }
}