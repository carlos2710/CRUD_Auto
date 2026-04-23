namespace Cars.Web.Services;

using System.Net.Http.Json;
using Cars.Web.Models;

public class CarService
{
    private readonly HttpClient _http;

    public CarService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<CarDto>?> GetAllAsync()
    {
        return await _http.GetFromJsonAsync<List<CarDto>>("api/cars");
    }

    public async Task<CarDto?> GetByIdAsync(int id)
        => await _http.GetFromJsonAsync<CarDto>($"api/cars/{id}");

    public async Task<bool> CreateAsync(CarDto car)
    {

        var response = await _http.PostAsJsonAsync("api/cars", car);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(CarDto car)
    {
        var response = await _http.PutAsJsonAsync($"api/cars/{car.Id}", car);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _http.DeleteAsync($"api/cars/{id}");
        return response.IsSuccessStatusCode;
    }
}