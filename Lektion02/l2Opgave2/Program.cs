using System.Globalization;
using Opgave02.model;

namespace Opgave02;

class Program
{
    static void Main(string[] args)
    {
        var products = SeedData.Products;
        var customers = SeedData.Customers;
        
        // For og finde alle i Elektronik uden count (for og sammenligne ) 
        products
            .Where(p => p.Category == Category.Elektronik)
            .ToList()
            .ForEach(product => Console.WriteLine(product));

        Console.WriteLine();
        // 1. Find alle produkter i kategorien Category.Elektronik, som er på lager (StockCount > 0)
        var result = products
            .Where(p => p.Category == Category.Elektronik && p.StockCount > 0)
            .ToList();
        foreach (var p in result)
        {
            Console.WriteLine(p);
        }

        Console.WriteLine();
        // 2. Udskriv navn og pris for disse produkter, sorteret efter pris i faldende rækkefølge (dyreste først)
        var sortedResult = result
            .OrderByDescending(p => p.Price)
            .ToList();

        foreach (var p in sortedResult)
        {
            Console.WriteLine(p.Name + " " + p.Price);
        }

        Console.WriteLine();
        // Eller lav den direkte på result 
        // foreach (var p in result.OrderByDescending(p => p.Price))
        // {
        //     Console.WriteLine(p.Name + " " + p.Price);
        // }

        // 3. Find alle kunder fra byen "Aarhus" og udskriv deres navne
        customers
            .Where(c => c.City == "Aarhus")
            .ToList()
            .ForEach(customer => Console.WriteLine(customer.Name));
        Console.WriteLine();
        //Tjek alle for se, om det passer 
        customers
            .ToList()
            .ForEach(customer => Console.WriteLine(customer));

        Console.WriteLine();
        //4 Bonus: Find de 3 mest solgte produkter målt på samlet solgt antal.
        customers
            .SelectMany(c => c.Orders)
            .SelectMany(o => o.Items)
            .GroupBy(i => i.Product)
            .Select(g => new { Product = g.Key, Count = g.Sum(i => i.Quantity) })
            .OrderByDescending(i => i.Count)
            .Take(3)
            .ToList()
            .ForEach(f => Console.WriteLine($"Product: {f.Product.Name}, Antal solgte: {f.Count}"));

        Console.WriteLine();
        //Bonus: Lav en opgørelse over alle kunder og deres samlede købsbeløb i shoppen.
       // For hver kunde beregnes den samlede omsætning: ∑(Quantity × Price).
       var cus = customers
           .ToList();
       foreach (var c in cus)
       {
           decimal omsætning = c.Orders
               .Sum(order => order.Items.Sum(item => item.Quantity * item.Product.Price));

           Console.WriteLine(c.Name + ": " + omsætning);
       }

       Console.WriteLine();
       //Projicer til en anonym type: { CustomerName, OrderCount, TotalSpent }.
       var opgørelse = customers.Select(c=> new 
       {
           CustomerName = c.Name,
           OrderCount = c.Orders.Count,
           TotalSpent = c.Orders.Sum(order => order.Items.Sum(item => item.Product.Price * item.Quantity))
       });
       foreach (var o in opgørelse)
       {
           Console.WriteLine(o.CustomerName + ": " + o.OrderCount + " ordrer, " + o.TotalSpent + " kr.");
       }
       
       
       //Inkluder også kunder, der har 0 ordrer (f.eks. Clara Møller – skal have TotalSpent = 0).
       
       
       //Sorter kunderne, så den med højst forbrug kommer først. • Fokus-metoder: Select, SelectMany, DefaultIfEmpty, Sum, OrderByDescending.

    }
}
