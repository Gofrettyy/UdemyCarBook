using System.Diagnostics;
using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.ServiceCommands;

public class RemoveServiceCommand :IRequest
{
    public RemoveServiceCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}