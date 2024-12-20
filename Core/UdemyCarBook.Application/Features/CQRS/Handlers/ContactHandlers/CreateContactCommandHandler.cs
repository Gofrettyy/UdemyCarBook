using UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class CreateContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public CreateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateContactCommand command)
    {
        await _repository.CreateAsync(new Contact
        {
            Name = command.Name,
            Email = command.Email,
            Message = command.Message,
            Subject = command.Subject,
        });
        
    }
}