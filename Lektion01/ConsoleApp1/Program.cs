namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Student student = new();
        student.Name = "Mike Varming";
        student.Age = 30;
        Console.WriteLine($"Navn: {student.Name} Har alderen {student.Age}");

        var car1 = new Car("Renault", "5", 2025);
        var car2 = new Car("Renault", "5", 2025);
        Console.WriteLine(car1 == car2);
        Console.WriteLine(car1);
        var (brand, model, year) = car2;


    }
}