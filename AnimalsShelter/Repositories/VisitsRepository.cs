using AnimalsShelter.Models;

namespace AnimalsShelter.Repositories;

public class VisitsRepository : IVisitsRepository
{
    private readonly IAnimalsRepository _animalsRepository;
    private readonly List<Visit> _visits;
    public VisitsRepository (IAnimalsRepository animalsRepositoryRepository)
    {
        _animalsRepository = animalsRepositoryRepository;
        
        _visits = new List<Visit>
        {
            new Visit { Date = "02.01.2024", Animal = _animalsRepository.GetAnimal(1), Description = "Vaccination", Cost = 50.0 },
            new Visit { Date = "05.04.2024", Animal = _animalsRepository.GetAnimal(1), Description = "Control visit", Cost = 30.0 },
            new Visit { Date = "20.08.2023", Animal = _animalsRepository.GetAnimal(2), Description = "Control visit", Cost = 50.0 },
            new Visit { Date = "15.01.2024", Animal = _animalsRepository.GetAnimal(2), Description = "Vaccination", Cost = 20.0 },
            new Visit { Date = "10.12.2020", Animal = _animalsRepository.GetAnimal(3), Description = "Control visit", Cost = 20.0 }
        };
        
    }
    
    public int CreateVisit(Visit visit)
    {
        _visits.Add(visit);
        return _visits.Count;
    }

    public IEnumerable<Visit> GetVisitsByAnimalId(int animalId)
    {
        return _visits.Where(v => v.Animal.Id == animalId);
    }
}