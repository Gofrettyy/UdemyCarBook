using UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class UpdateContactCommandHandler
{
    private readonly IRepository<Contact>? _repository;

    public UpdateContactCommandHandler(IRepository<Contact>? repository)
    {
        _repository = repository;
    }


    public async Task Handle(UpdateContactCommand command)
    {
        var values = await _repository.GetByIdAsync(command.ContactId);
        values.ContactId = command.ContactId;
        values.Name = command.Name;
        values.Email = command.Email;
        values.Message = command.Message;
        values.SendDate = DateTime.Now;
        values.Subject = command.Subject;
        
        await _repository.UpdateAsync(values);
    }
}