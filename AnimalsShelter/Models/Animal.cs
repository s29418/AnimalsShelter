namespace AnimalsShelter.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public AnimalType Type { get; set; }
    public double Weight { get; set; }
    public string FurColor { get; set; }
    public List<Visit> Visits { get; set; }
}