namespace UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;

public class CreateCarCommand
{
    public int BrandId { get; set; }
    public string Model { get; set; } = null!;
    public string CoverImageUrl { get; set; }
    public int Km { get; set; }
    public string Transmission { get; set; }
    public byte Seat { get; set; }
    public byte Luggage{ get; set; }
    public string Fuel { get; set; }
    public string BigImageUrl { get; set; }
}