using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));

        Address address2 = new Address("456 King Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maria Silva", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "P2001", 600, 1));
        order2.AddProduct(new Product("Keyboard", "P2002", 80, 1));
        order2.AddProduct(new Product("Headset", "P2003", 150, 1));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order.GetTotalPrice()}");
        Console.WriteLine("-----------------------------------");
    }
}
