namespace AnimalsShelter.Models;

public class Visit
{
    public string Date { get; set; }
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public double Cost { get; set; }
}