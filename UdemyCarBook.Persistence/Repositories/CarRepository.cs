using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories;

public class CarRepository : ICarRepository
{
    private readonly CarBookContext _carBookContext;

    public CarRepository(CarBookContext carBookContext)
    {
        _carBookContext = carBookContext;
    }

    public List<Car> GetCarsWithBrands()
    {
        var values = _carBookContext.Cars.Include(x => x.Brand).ToList();
        return values;
    }
}