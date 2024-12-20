using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;

public class UpdateSocialMediaCommand :IRequest
{
    public int SocialMediaID { get; set; }
    public string Title { get; set; }
    public string Icon { get; set; }
    public string Url { get; set; }
}