using UdemyCarBook.Application.Features.CQRS.Results.AboutResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers;

public class GetAboutQueryHandler
{
    private readonly IRepository<About> _repository;

    public GetAboutQueryHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetAboutQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x=>new GetAboutQueryResult
        {
            AboutID = x.AboutID,
            Description = x.Description,
            Title = x.Title,
            ImageUrl = x.ImageUrl,
            
        }).ToList();// böylelikle GetAboutQueryHandler istediğimiz formatta oluşmuş oldu.
    }
}