using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces;

public interface ICarRepository
{
    List<Car> GetCarsWithBrands();
}