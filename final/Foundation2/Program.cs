using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is Foundation 2 Program!\n");

        List<Order> _orders = new List<Order>();

        //-----ORDER Nª1--------
        //Creating customer 1
        Customer customer1 = new Customer("Steven");
        Address address1 = new Address("Main Street", "Salt Lake", "Utah", "USA");
        customer1.SetAddress(address1);

        //Creating two products
        Product product1 = new Product("iPhone 12", 8, 1000, 1);
        Product product2 = new Product("iPad", 5, 600, 2);

        //Now, we can create the order and add the products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        //Finally, add the order to a general list of orders
        _orders.Add(order1);


        //-----ORDER Nª2--------
        //Creating customer 2
        Customer customer2 = new Customer("Paul");
        Address address2 = new Address("Diagonal", "Lima", "Lima", "Peru");
        customer2.SetAddress(address2);

        //Creating two products
        Product product3 = new Product("MacBook Pro", 2, 2000, 1);
        Product product4= new Product("iPod", 3, 100, 3);

        //Now, we can create the order and add the products
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        //Finally, add the order to a general list of orders
        _orders.Add(order2);



        //DISPLAY EVERYTHING
        //Iterate through each order and display results
        int count = 1;
        foreach(Order order in _orders)
        {
            Console.WriteLine("\nORDER #" + count);
            Console.WriteLine("The packing label of this order: ");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("The shipping label of this order: ");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("\nThe total price of this order is: " + order.CalculateTotalCost());
            count++;
        }
        
    }
}