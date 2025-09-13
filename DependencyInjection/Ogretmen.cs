namespace DependencyInjection;

public class Ogretmen : IOgretmen
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Ogretmen(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetInfo()
    {
        return $"Öğretmen: {FirstName} {LastName}";
    }
}


