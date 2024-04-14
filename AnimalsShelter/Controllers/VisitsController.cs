using AnimalsShelter.Models;
using AnimalsShelter.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsShelter.Controllers;

[Route("api/visits")]
[ApiController]
public class VisitsController : ControllerBase
{

    private readonly IVisitsService _visitsService;
    
    public VisitsController(IVisitsService visitsService)
    {
        _visitsService = visitsService;
    }

    [HttpPost]
    public IActionResult CreateVisit(Visit visit)
    {
        var affectedCount = _visitsService.CreateVisit(visit);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetVisitByAnimalId(int id)
    {
        var visits = _visitsService.GetVisitsByAnimalId(id);
        return Ok(visits);
    }
    
}