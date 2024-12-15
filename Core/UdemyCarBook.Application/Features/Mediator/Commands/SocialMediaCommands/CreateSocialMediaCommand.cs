using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;

public class CreateSocialMediaCommand: IRequest
{
    public string Title { get; set; }
    public string Icon { get; set; }
    public string Url { get; set; }
}