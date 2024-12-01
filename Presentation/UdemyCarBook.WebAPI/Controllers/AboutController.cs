using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries;

namespace UdemyCarBook.WebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AboutController : Controller
{
    private readonly CreateAboutCommandHandler _createAboutCommandHandler;
    private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
    private readonly GetAboutQueryHandler _getAboutQueryHandler;
    private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;
    private readonly RemoveAboutCommandHandler _removeAboutCommandHandler;

    public AboutController(CreateAboutCommandHandler createAboutCommandHandler, GetAboutByIdQueryHandler getAboutByIdQueryHandler, GetAboutQueryHandler getAboutQueryHandler, UpdateAboutCommandHandler updateAboutCommandHandler, RemoveAboutCommandHandler removeAboutCommandHandler)
    {
        _createAboutCommandHandler = createAboutCommandHandler;
        _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
        _getAboutQueryHandler = getAboutQueryHandler;
        _updateAboutCommandHandler = updateAboutCommandHandler;
        _removeAboutCommandHandler = removeAboutCommandHandler;
    } //ilgili metodlar için ilgili sınıflara erişim sağlama amacıyla constructor oluşturduk.

    [HttpGet]
    public async Task<IActionResult> AboutList()
    {
        var values = await _getAboutQueryHandler.Handle();
        return Ok(values); //Abouttaki verileri döndürüyoruz.
    }

    [HttpGet("{id}")]

    public async Task<IActionResult> GetAbout(int id)
    {
        var value = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
        return Ok(value); 
    }

    [HttpPost]
    public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
    {
        await _createAboutCommandHandler.Handle(command);
        return Ok("About created");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveAbout(int id)
    {
        await _removeAboutCommandHandler.Handle(new RemoveAboutCommand(id));
        return Ok("About removed");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
    {
        await _updateAboutCommandHandler.Handle(command);
        return Ok("About updated");
    }

}