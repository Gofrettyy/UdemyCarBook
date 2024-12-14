using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.LocationCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.LocationQueries;

namespace UdemyCarBook.WebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class LocationControllers : Controller
{
    private readonly IMediator _mediator;

    public LocationControllers(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]

    public async Task<IActionResult> LocationList()
    {
        var values = await _mediator.Send(new GetLocationQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetLocation(int id)
    {
        var value = await _mediator.Send(new GetLocationByIdQuery(id));
        return Ok(value);

    }

    [HttpPost]
    public async Task<IActionResult> CreateLocation([FromBody] CreateLocationCommand command)
    {
        await _mediator.Send(command);
        return Ok("Location created");
    }

    [HttpPut]

    public async Task<IActionResult> UpdateLocation([FromBody] UpdateLocationCommand command)
    {
        await _mediator.Send(command);
        return Ok("Location updated");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveLocation(int id)
    {
        await _mediator.Send(new RemoveLocationCommand(id));
        return Ok("Location removed");
    }
}
