using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("245 Lexington Ave", "New York", "NY", "", "USA");
        Customer customer1 = new Customer("Thomas Johnson", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Ena Truemade Whey Protein Chocolate Flavor", 1931, 44, 2);
        Product product2 = new Product("NZXT BLD Player: One", 1520, 735, 1);
        order1.AddProducts(product1);
        order1.AddProducts(product2);

        Console.WriteLine("\n---------ORDER N°1----------\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total: $" + order1.CalculateTotalCost());
        Console.WriteLine("\n-----------------------------\n");


        Address address2 = new Address("Av. San Martín 57", "Ciudad de Mendoza", "", "Mendoza", "Argentina");
        Customer customer2 = new Customer("Valentina Romero", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("'And Then There Were None' by Agatha Christie", 315, 25, 3);
        Product product4 = new Product("ChessUp 2 electronic boards Bryght Labs", 528, 105, 2);
        order2.AddProducts(product3);
        order2.AddProducts(product4);

        Console.WriteLine("\n---------ORDER N°2----------\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total: $" + order2.CalculateTotalCost());
        Console.WriteLine("\n-----------------------------\n");

    }
}