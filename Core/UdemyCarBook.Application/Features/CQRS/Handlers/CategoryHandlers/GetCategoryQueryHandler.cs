using UdemyCarBook.Application.Features.CQRS.Results.BrandResults;
using UdemyCarBook.Application.Features.CQRS.Results.CategoryResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;

public class GetCategoryQueryHandler
{
    private readonly IRepository<Category> _repository;

    public GetCategoryQueryHandler(IRepository<Category> categoryRepository)
    {
        _repository = categoryRepository;
    }

    public async Task<List<GetCategoryQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetCategoryQueryResult
        { 
            CategoryId = x.CategoryId,
            CategoryName = x.CategoryName,
        }).ToList();
    }
}