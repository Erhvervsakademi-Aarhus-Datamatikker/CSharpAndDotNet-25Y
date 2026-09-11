namespace Opgave05;

class Program
{
    static void Main(string[] args)
    {
        var c1 = new GeoPointClass{ Latitude = 55.15, Longitude = 10.20};
        var c2 = new GeoPointClass{ Latitude = 55.15, Longitude = 10.20};
        
        var r1 = new  GeoPointRecord(56.15, 10.20);
        var r2 = new  GeoPointRecord(56.15, 10.20);

        Console.WriteLine(c1 == c2);
        Console.WriteLine(r1 == r2);
        
        Console.WriteLine(c1);
        Console.WriteLine(r1);
        
    }
}