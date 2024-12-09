using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.FeatureCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.FeatureQuery;

namespace UdemyCarBook.WebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class FeatureControllers : Controller
{
   private readonly IMediator _mediator;

   public FeatureControllers(IMediator mediator)
   {
      _mediator = mediator;
   }

   [HttpGet]

   public async Task<IActionResult> FeatureList()
   {
      var values = await _mediator.Send(new GetFeatureQuery());
      return Ok(values);
   }

   [HttpGet("{id}")]
   public async Task<IActionResult> GetFeature(int id)
   {
      var value = await _mediator.Send(new GetFeatureByIdQuery(id));
      return Ok(value);

   }

   [HttpPost]
   public async Task<IActionResult> CreateFeature([FromBody] CreateFeatureCommand command)
   {
      await _mediator.Send(command);
      return Ok("Feature created");
   }

   [HttpPut]

   public async Task<IActionResult> UpdateFeature([FromBody] UpdateFeatureCommand command)
   {
      await _mediator.Send(command);
      return Ok("Feature updated");
   }

   [HttpDelete]

   public async Task<IActionResult> RemoveFeature(int id)
   {
      await _mediator.Send(new RemoveFeatureCommand(id));
      return Ok("Feature removed");
   }
}