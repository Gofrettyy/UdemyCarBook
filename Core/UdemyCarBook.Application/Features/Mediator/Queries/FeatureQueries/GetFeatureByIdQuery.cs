using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FeatureQuery;

public class GetFeatureByIdQuery :IRequest<GetFeatureByIdQueryResult>
{
    public GetFeatureByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}