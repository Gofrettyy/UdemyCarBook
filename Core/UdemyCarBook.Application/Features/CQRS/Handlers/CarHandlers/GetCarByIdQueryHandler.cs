using UdemyCarBook.Application.Features.CQRS.Queries.CarQueries;
using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarByIdQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarByIdQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
    
    { 
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetCarByIdQueryResult()
        {
            BrandId = value.BrandId,
            CarId = value.CarId,
            BigImageUrl = value.BigImageUrl,
            CoverImageUrl = value.CoverImageUrl,
            Fuel = value.Fuel,
            Km = value.Km,
            Luggage = value.Luggage,
            Model = value.Model,
            Transmission = value.Transmission,
            Seat = value.Seat

        };
    }
}