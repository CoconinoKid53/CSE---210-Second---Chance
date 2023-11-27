using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)

    {
        Address address = new Address( "500 W s 3rd st", "Huntington Beach", "USA",92605);
        Customer customer = new Customer("Vincent", address);
        Address address1 = new Address("2096 Coconino Dr", "Blythe","USA",92225);
        Customer customer2 = new Customer("Ben",address);
        List<Product> products = new List<Product>()
        {
          new Product("Oreo",5,2,3879),
          new Product("Pepsi",8,1,3897)   
        };
       
       Order order = new Order(products,customer);
       Order order1 = new Order(products,customer2);

       Console.WriteLine("Thanks for shopping with US!");
       Console.WriteLine(order._packingLabel());

    }
}