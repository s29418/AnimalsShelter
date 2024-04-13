using AnimalsShelter.Models;

namespace AnimalsShelter.Services;

public interface IVisitsService
{
    IEnumerable<Visit> GetVisitsByAnimalId(int animalId);
    int CreateVisit(Visit visit);
}