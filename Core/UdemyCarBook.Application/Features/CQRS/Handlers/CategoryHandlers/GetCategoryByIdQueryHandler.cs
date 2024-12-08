using UdemyCarBook.Application.Features.CQRS.Queries.BrandQueries;
using UdemyCarBook.Application.Features.CQRS.Queries.CategoryQueries;
using UdemyCarBook.Application.Features.CQRS.Results.BrandResults;
using UdemyCarBook.Application.Features.CQRS.Results.CategoryResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;

public class GetCategoryByIdQueryHandler
{
    private readonly IRepository<Category> _repository;

    public GetCategoryByIdQueryHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetCategoryByIdQueryResult
        {
            CategoryId = value.CategoryId,
            CategoryName = value.CategoryName,

        };
    }
}