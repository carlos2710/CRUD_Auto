using Microsoft.AspNetCore.Mvc;
using Cars.Web.Models;
using Cars.Web.Services;

public class CarsController : Controller
{
    private readonly CarService _service;

    public CarsController(CarService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var cars = await _service.GetAllAsync();
        return View(cars);
    }

    public IActionResult Create() => View();

    [HttpPost]
    public async Task<IActionResult> Create(CarDto model)
    {

        if (!ModelState.IsValid) return View(model);

        await _service.CreateAsync(model);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Edit(int id)
    {
        var car = await _service.GetByIdAsync(id);
        return View(car);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(CarDto model)
    {
        await _service.UpdateAsync(model);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(int id)
    {
        var car = await _service.GetByIdAsync(id);
        return View(car);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction("Index");
    }
}