using UdemyCarBook.Application.Features.CQRS.Queries.CategoryQueries;
using UdemyCarBook.Application.Features.CQRS.Queries.ContactQueries;
using UdemyCarBook.Application.Features.CQRS.Results.CategoryResult;
using UdemyCarBook.Application.Features.CQRS.Results.ContactResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class GetContactByIdQueryHandler
{
    private readonly IRepository<Contact> _repository;

    public GetContactByIdQueryHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetContactByIdQueryResult
        {
            ContactId = value.ContactId, 
            Name = value.Name,
            Email = value.Email,
            Message = value.Message,
            SendDate = value.SendDate,
            Subject = value.Subject,
            

        };
    }
}