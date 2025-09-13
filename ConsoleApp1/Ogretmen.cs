namespace ConsoleApp1;

public class Ogretmen : IOgretmen
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public Ogretmen() { }

    public string GetInfo()
    {
        return $"Öğretmen: {FirstName} {LastName}";
    }
}


