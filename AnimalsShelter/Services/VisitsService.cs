using AnimalsShelter.Models;
using AnimalsShelter.Repositories;

namespace AnimalsShelter.Services;

public class VisitsService : IVisitsService
{
    private readonly IVisitsRepository _visitsRepository;

    public VisitsService(IVisitsRepository visitsRepository)
    {
        _visitsRepository = visitsRepository;
    }

    public IEnumerable<Visit> GetVisitsByAnimalId(int animalId)
    {
        return _visitsRepository.GetVisitsByAnimalId(animalId);
    }

    public int CreateVisit(Visit visit)
    {
        return _visitsRepository.CreateVisit(visit);
    }
}