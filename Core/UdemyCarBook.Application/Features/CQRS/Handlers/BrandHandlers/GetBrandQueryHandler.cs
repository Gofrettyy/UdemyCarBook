using UdemyCarBook.Application.Features.CQRS.Results.BrandResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BrandHandlers;

public class GetBrandQueryHandler
{
    private readonly IRepository<Brand> _repository;

    public GetBrandQueryHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetBrandQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetBrandQueryResult
        { 
            BrandId = x.BrandId,
            Name = x.Name,
        }).ToList();
    }
}

