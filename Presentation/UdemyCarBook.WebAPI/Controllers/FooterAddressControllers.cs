using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.FooterAddressQueries;


namespace UdemyCarBook.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FooterAddressControllers : Controller
{
    private readonly IMediator _mediator;

    public FooterAddressControllers(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]

    public async Task<IActionResult> FooterAddressList()
    {
        var values = await _mediator.Send(new GetFooterAddressQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFooterAddress(int id)
    {
        var value = await _mediator.Send(new GetFooterAddressByIdQuery(id));
        return Ok(value);

    }

    [HttpPost]
    public async Task<IActionResult> CreateFooterAddress([FromBody] CreateFooterAddressCommand command)
    {
        await _mediator.Send(command);
        return Ok("FooterAddress created");
    }

    [HttpPut]

    public async Task<IActionResult> UpdateFooterAddress([FromBody] UpdateFooterAddressCommand command)
    {
        await _mediator.Send(command);
        return Ok("FooterAddress updated");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveFooterAddress(int id)
    {
        await _mediator.Send(new RemoveFooterAddressCommand(id));
        return Ok("FooterAddress removed");
    }
}
