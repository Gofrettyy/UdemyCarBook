using UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;

public class RemoveCategoryCommandHandler
{
    private readonly IRepository<Category> _categoryRepository;

    public RemoveCategoryCommandHandler(IRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task Handle(RemoveCategoryCommand command)
    {
        var value = await _categoryRepository.GetByIdAsync(command.Id);
        await _categoryRepository.RemoveAsync(value);
    }
}