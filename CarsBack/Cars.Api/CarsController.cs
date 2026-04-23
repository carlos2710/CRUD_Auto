using Microsoft.AspNetCore.Mvc;
using Cars.Infrastructure;
using Cars.Domain;

namespace Cars.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
    private readonly CarRepository _repo;

    public CarsController(CarRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _repo.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var car = await _repo.GetByIdAsync(id);
        return car == null ? NotFound() : Ok(car);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Car car)
    {
        await _repo.AddAsync(car);
        return Ok(car);
    }

    [HttpPut]
    public async Task<IActionResult> Update(Car car)
    {
        await _repo.UpdateAsync(car);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _repo.DeleteAsync(id);
        return Ok();
    }
}