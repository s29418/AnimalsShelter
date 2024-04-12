using AnimalsShelter.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsShelter.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    
    private static readonly List<Animal> _animals = new()
    {
        new Animal { Id = 1, Name = "Fiona", Type = AnimalType.Dog, Weight = 12.5, FurColor = "White" },
        new Animal { Id = 2, Name = "Bella", Type = AnimalType.Cat, Weight = 4.5, FurColor = "Black" },
        new Animal { Id = 3, Name = "Bodzio", Type = AnimalType.Bird, Weight = 0.5, FurColor = "Green" }
    };
    

    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(animal => animal.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }
        
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animalToEdit = _animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        _animals.Remove(animalToEdit);
        _animals.Add(animal);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToDelete = _animals.FirstOrDefault(a => a.Id == id);

        if (animalToDelete == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        _animals.Remove(animalToDelete);
        return NoContent();
    }
}