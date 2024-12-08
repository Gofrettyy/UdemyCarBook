using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarWithBrandQueryHandler
{
    private readonly ICarRepository _carRepository;

    public GetCarWithBrandQueryHandler(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public List<GetCarWithBrandQueryResult> Handle()
    {
        var values =  _carRepository.GetCarsWithBrands();
        return values.Select(x => new GetCarWithBrandQueryResult()
            { 
                CarId = x.CarId,
                BrandName = x.Brand.Name,
                BrandId = x.BrandId,
                BigImageUrl = x.BigImageUrl,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Transmission = x.Transmission,
                Seat = x.Seat
            }).ToList();
        
    }
}