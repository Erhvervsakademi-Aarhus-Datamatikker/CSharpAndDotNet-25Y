namespace Opgave04;

class Program
{
    static void Main(string[] args)
    {
        var laptop = new Product("1", "ThinkPad", 5000, "IT");
        var Jordbær = new Product("2", "Dansk-Jordbær", 25, "Mad");
        var volleyBall = new Product("2", "VolleyBall-Ball", 540, "Sport");

        var discoundt = laptop with { Price = 4000 };
        Console.WriteLine(laptop);
        Console.WriteLine(discoundt);
        
        var (id, name, price, category) = laptop;
        Console.WriteLine($"Vare: {name}, Pris: {price}");
        
    }
    
    
}