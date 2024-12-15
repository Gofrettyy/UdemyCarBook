using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.ServiceCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.ServiceQueries;

namespace UdemyCarBook.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServiceControllers : Controller
{
    private readonly IMediator _mediator;

    public ServiceControllers(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]

    public async Task<IActionResult> ServiceList()
    {
        var values = await _mediator.Send(new GetServiceQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetService(int id)
    {
        var value = await _mediator.Send(new GetServiceByIdQuery(id));
        return Ok(value);

    }

    [HttpPost]
    public async Task<IActionResult> CreateService([FromBody] CreateServiceCommand command)
    {
        await _mediator.Send(command);
        return Ok("Service created");
    }

    [HttpPut]

    public async Task<IActionResult> UpdateService([FromBody] UpdateServiceCommand command)
    {
        await _mediator.Send(command);
        return Ok("Service updated");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveService(int id)
    {
        await _mediator.Send(new RemoveServiceCommand(id));
        return Ok("Service removed");
    }
}
