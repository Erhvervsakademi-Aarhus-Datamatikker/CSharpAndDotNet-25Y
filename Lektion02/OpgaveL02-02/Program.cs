using System.Globalization;
using Opgave02.model;

namespace Opgave02;

class Program
{
    static void Main(string[] args)
    {
        var products = SeedData.Products;
        var customers = SeedData.Customers;
        // 1. Find alle produkter i kategorien Category.Elektronik, som er på lager (StockCount > 0)
        
        // 2. Udskriv navn og pris for disse produkter, sorteret efter pris i faldende rækkefølge (dyreste først)
        var elektronik = products
            .Where(p => p.Category == Category.Elektronik && p.StockCount > 0)
            .OrderByDescending(p => p.Price);

        foreach (var p in elektronik)
        {
            Console.WriteLine($"{p.Name} - {p.Price} kr.");
        }

        // 3. Find alle kunder fra byen "Aarhus" og udskriv deres navne
        var aarhus = customers.Where(c => c.City == "Aarhus");

        foreach (var c in aarhus)
        {
            Console.WriteLine(c.Name);
        }
    }
}
