using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;

public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
{
    private readonly IRepository<SocialMedia> _repository;

    public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(new SocialMedia
        {
            SocialMediaID = request.SocialMediaID,
            Title = request.Title,
            Url = request.Url,
            Icon = request.Icon,
        });
    }
}