using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Commands.BrandCommands;

public class UpdateBrandCommand
{
    public int BrandId { get; set; }
    public string Name { get; set; }
}