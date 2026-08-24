namespace ConsoleApp1;

public class Student
{
    public string Name { get; set; } = string.Empty;
    private int _age; // Private backing field

    public int Age
    {
        get 
        { 
            return _age; 
        }
        set 
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Alder kan ikke være negativ");
            _age = value;
        }
    }
}