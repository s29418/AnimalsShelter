using AnimalsShelter.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsShelter.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    
    private static readonly List<Animal> _animals = new()
    {
        new Animal { Id = 1, Name = "Fiona", Type = AnimalType.Dog, Weight = 12.5, FurColor = "White", Visits = new List<Visit>
            {
                new Visit { Date = "02.01.2024", Description = "Vaccination", Cost = 50.0 },
                new Visit { Date = "05.04.2024", Description = "Control visit", Cost = 30.0 }
            }
        },
        new Animal { Id = 2, Name = "Bella", Type = AnimalType.Cat, Weight = 4.5, FurColor = "Black", Visits = new List<Visit>
            {
                new Visit { Date = "20.08.2023", Description = "Control visit", Cost = 50.0 },
                new Visit { Date = "15.01.2024", Description = "Vaccination", Cost = 20.0 }
            }
        },
        new Animal { Id = 3, Name = "Max", Type = AnimalType.Bird, Weight = 0.5, FurColor = "Green", Visits = new List<Visit>
            {
                new Visit { Date = "10.12.2020", Description = "Control visit", Cost = 20.0 },
            }
        }
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

    [HttpPut("{int:id}")]
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

    [HttpDelete("{int:id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToDelete = _animals.FirstOrDefault(a => a.Id == id);

        if (animalToDelete == null)
        {
            NotFound($"Animal with id {id} was not found");
        }

        _animals.Remove(animalToDelete);
        return NoContent();
    }
}