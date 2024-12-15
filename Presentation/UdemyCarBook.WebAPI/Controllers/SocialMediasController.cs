using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;

namespace UdemyCarBook.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SocialMediaControllers : Controller
{
    private readonly IMediator _mediator;

    public SocialMediaControllers(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]

    public async Task<IActionResult> SocialMediaList()
    {
        var values = await _mediator.Send(new GetSocialMediaQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSocialMedia(int id)
    {
        var value = await _mediator.Send(new GetSocialMediaByIdQuery(id));
        return Ok(value);

    }

    [HttpPost]
    public async Task<IActionResult> CreateSocialMedia([FromBody] CreateSocialMediaCommand command)
    {
        await _mediator.Send(command);
        return Ok("SocialMedia created");
    }

    [HttpPut]

    public async Task<IActionResult> UpdateSocialMedia([FromBody] UpdateSocialMediaCommand command)
    {
        await _mediator.Send(command);
        return Ok("SocialMedia updated");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveSocialMedia(int id)
    {
        await _mediator.Send(new RemoveSocialMediaCommand(id));
        return Ok("SocialMedia removed");
    }
}
