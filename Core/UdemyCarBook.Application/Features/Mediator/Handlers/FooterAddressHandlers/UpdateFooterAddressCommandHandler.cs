using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;

public class UpdateFooterAddressCommandHandler:IRequestHandler<UpdateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }


    public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
    {
      await _repository.UpdateAsync(new FooterAddress
      {
          FooterAddressID = request.FooterAddressID,
          Description = request.Description,
          Email = request.Email,
          Phone = request.Phone,
          Address = request.Address
      });
    }
}