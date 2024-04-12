using AnimalsShelter.Models;

namespace AnimalsShelter.Repositories;

public interface IAnimalsRepository
{
    IEnumerable<Animal> getAnimals();
    int CreateAnimal(Animal animal);
    Animal GetAnimal(int idAnimal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}