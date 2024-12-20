using MediatR;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Commands.FeatureCommands;

public class RemoveFeatureCommand :IRequest
{
    public RemoveFeatureCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
   
}