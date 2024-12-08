using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetCarQueryResult
        { 
            CarId = x.CarId,
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