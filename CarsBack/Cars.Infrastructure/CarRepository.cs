using Microsoft.EntityFrameworkCore;
using Cars.Domain;

namespace Cars.Infrastructure;

public class CarRepository
{
    private readonly AppDbContext _context;

    public CarRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Car>> GetAllAsync() =>
        await _context.Cars.ToListAsync();

    public async Task<Car?> GetByIdAsync(int id) =>
        await _context.Cars.FindAsync(id);

    public async Task AddAsync(Car car)
    {
        await _context.Cars.AddAsync(car);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Car car)
    {
        _context.Cars.Update(car);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var car = await _context.Cars.FindAsync(id);
        if (car != null)
        {
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
        }
    }
}