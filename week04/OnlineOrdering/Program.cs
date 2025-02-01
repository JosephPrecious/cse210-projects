using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Alice Smith", new Address("456 Elm St", "Toronto", "ON", "Canada"));

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.50m, 2));
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P2001", 200.00m, 1));
        order2.AddProduct(new Product("Keyboard", "P2002", 50.00m, 1));
        
        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}