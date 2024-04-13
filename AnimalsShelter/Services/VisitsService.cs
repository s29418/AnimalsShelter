using AnimalsShelter.Models;

namespace AnimalsShelter.Services;

public class VisitsService
{
    private readonly IVisitsService _visitsService;
    
    public VisitsService(IVisitsService visitsService)
    {
        _visitsService = visitsService;
    }
    
    public IEnumerable<Visit> GetVisitsByAnimalId(int animalId)
    {
        return _visitsService.GetVisitsByAnimalId(animalId);
    }
    
    public int CreateVisit(Visit visit)
    {
        return _visitsService.CreateVisit(visit);
    }
    
}