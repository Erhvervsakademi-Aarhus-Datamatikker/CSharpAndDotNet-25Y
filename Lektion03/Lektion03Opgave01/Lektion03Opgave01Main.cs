namespace Lektion03Opgave01;

class Lektion03Opgave01Main
{
    
    public delegate double MathOperation(double a, double b);

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static void ExectueAndPrint(double a, double b, MathOperation operation)
    {
        double result = operation(a, b);
        Console.WriteLine(result);
    }
    
    static void Main(string[] args)
    {
        
        ExectueAndPrint(10, 5, Add);
        ExectueAndPrint(5, 4, Add);
        ExectueAndPrint(3, 10, Add);
        
        ExectueAndPrint(1, 5, (x, y) => x / y);
        
        ExectueAndPrint(10, 5 , (x, y) => Math.Pow(x, y));
        
        
    }
}