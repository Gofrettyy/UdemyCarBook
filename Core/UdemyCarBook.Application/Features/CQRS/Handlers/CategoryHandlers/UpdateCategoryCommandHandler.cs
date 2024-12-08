using UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;

public class UpdateCategoryCommandHandler
{
    private readonly IRepository<Category> _categoryRepository;

    public UpdateCategoryCommandHandler(IRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task Handle(UpdateCategoryCommand command)
    {
        var values = await _categoryRepository.GetByIdAsync(command.CategoryId);
        values.CategoryId = command.CategoryId;
        values.CategoryName = command.CategoryName;
        await _categoryRepository.UpdateAsync(values);
    }
}