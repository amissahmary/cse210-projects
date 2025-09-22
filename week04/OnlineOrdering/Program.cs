using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address _loc1 = new Address("Abuja street", "Abuja", "Lagos", "Nigeria");
        Customer _cust1 = new Customer("Mariam", _loc1);

        Product prod1 = new Product();
        prod1.SetProductName("Milk");
        prod1.SetId("M123");
        prod1.SetPrice(12.5);
        prod1.SetQuantity(2);
        
        Product prod2 = new Product();
        prod2.SetProductName("Biscuit");
        prod2.SetId("B223");
        prod2.SetPrice(10.5);
        prod2.SetQuantity(4);

        Order _first = new Order(_cust1);
        _first.ProductList(prod1);
        _first.ProductList(prod2);

        Address _loc2 = new Address("Accra street", "Califonia", "Macedonia", "USA");
        Customer _cust2 = new Customer("Nelson", _loc2);

        Product prod3 = new Product();
        prod3.SetProductName("Gari");
        prod3.SetId("G23");
        prod3.SetPrice(2.5);
        prod3.SetQuantity(5);
        
        Product prod4 = new Product();
        prod4.SetProductName("Sugar");
        prod4.SetId("S523");
        prod4.SetPrice(10);
        prod4.SetQuantity(6);

        Order _second = new Order(_cust2);
        _second.ProductList(prod3);
        _second.ProductList(prod4);

        Console.WriteLine("PACKING LABEL:");
        Console.WriteLine(_first.PackingLabel());

        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(_first.ShippingLabel());

        Console.WriteLine($"TOTAL COST: ${_first.CalculateTotalCost()}\n");

        Console.WriteLine("PACKING LABEL:");
        Console.WriteLine(_second.PackingLabel());

        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(_second.ShippingLabel());

        Console.WriteLine($"TOTAL COST: ${_second.CalculateTotalCost()}\n");
    }
} 