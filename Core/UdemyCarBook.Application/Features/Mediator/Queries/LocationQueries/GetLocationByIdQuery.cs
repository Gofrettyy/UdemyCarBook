using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.LocationResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.LocationQueries;

public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
{
    public GetLocationByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}