using UdemyCarBook.Application.Features.CQRS.Results.CategoryResult;
using UdemyCarBook.Application.Features.CQRS.Results.ContactResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class GetContactQueryHandler
{
    private readonly IRepository<Contact> _repository;

    public GetContactQueryHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetContactQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetContactQueryResult
        { 
           ContactId = x.ContactId,
           Name = x.Name,
           Message = x.Message,
           Email = x.Email,
           SendDate = x.SendDate,
           Subject = x.Subject
        }).ToList();
    }
}