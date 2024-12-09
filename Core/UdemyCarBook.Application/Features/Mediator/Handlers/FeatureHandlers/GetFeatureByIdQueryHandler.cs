using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.FeatureQuery;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FeatureHandlers;

public class GetFeatureByIdQueryHandler:IRequestHandler<GetFeatureByIdQuery,GetFeatureByIdQueryResult>
{
    private readonly IRepository<Feature> _repository;

    public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
    {
        _repository = repository;
    }

    public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
    {
       var value = await _repository.GetByIdAsync(request.Id);
       return new GetFeatureByIdQueryResult
       {
          FeatureId = value.FeatureId,
          Name = value.Name,
       };
    }
}