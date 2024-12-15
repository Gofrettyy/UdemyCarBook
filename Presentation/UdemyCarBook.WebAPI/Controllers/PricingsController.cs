using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.PricingCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.PricingQueries;

namespace UdemyCarBook.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PricingsController : Controller
{
    private readonly IMediator _mediator;

    public PricingsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]

    public async Task<IActionResult> PricingList()
    {
        var values = await _mediator.Send(new GetPricingQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPricing(int id)
    {
        var value = await _mediator.Send(new GetPricingByIdQuery(id));
        return Ok(value);

    }

    [HttpPost]
    public async Task<IActionResult> CreatePricing([FromBody] CreatePricingCommand command)
    {
        await _mediator.Send(command);
        return Ok("Pricing created");
    }

    [HttpPut]

    public async Task<IActionResult> UpdatePricing([FromBody] UpdatePricingCommand command)
    {
        await _mediator.Send(command);
        return Ok("Pricing updated");
    }

    [HttpDelete]
    public async Task<IActionResult> RemovePricing(int id)
    {
        await _mediator.Send(new RemovePricingCommand(id));
        return Ok("Pricing removed");
    }
}
