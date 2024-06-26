﻿using AnimalsShelter.Models;

namespace AnimalsShelter.Repositories;

public interface IVisitsRepository
{
    IEnumerable<Visit> GetVisitsByAnimalId(int animalId);
    int CreateVisit(Visit visit);
    
}