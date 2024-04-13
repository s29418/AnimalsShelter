using AnimalsShelter.Models;

namespace AnimalsShelter.Repositories;

public class AnimalsRepository : IAnimalsRepository
{
    private static readonly List<Animal> _animals = new()
    {
        new Animal { Id = 1, Name = "Fiona", Type = AnimalType.Dog, Weight = 12.5, FurColor = "White" },
        new Animal { Id = 2, Name = "Bella", Type = AnimalType.Cat, Weight = 4.5, FurColor = "Black" },
        new Animal { Id = 3, Name = "Bodzio", Type = AnimalType.Bird, Weight = 0.5, FurColor = "Green" }
    };
    
    public IEnumerable<Animal> getAnimals()
    {
        return _animals;
    }

    public Animal GetAnimal(int idAnimal)
    {
        return _animals.FirstOrDefault(a => a.Id == idAnimal);
    }

    public int CreateAnimal(Animal animal)
    {
        _animals.Add(animal);
        return animal.Id;
    }

    public int UpdateAnimal(Animal animal)
    {
        var animalToUpdate = _animals.FirstOrDefault(a => a.Id == animal.Id);
        if (animalToUpdate != null)
        {
            _animals.Remove(animalToUpdate);
            _animals.Add(animal);
        }
        return animal.Id;
    }

    public int DeleteAnimal(int idAnimal)
    {
        var animalToDelete = _animals.FirstOrDefault(a => a.Id == idAnimal);
        if (animalToDelete != null)
        {
            _animals.Remove(animalToDelete);
        }
        return idAnimal;
    }
    
}