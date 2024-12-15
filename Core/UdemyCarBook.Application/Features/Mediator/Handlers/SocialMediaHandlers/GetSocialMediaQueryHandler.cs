using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;

public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery,List<GetSocialMediaQueryResult>>
{ 
    private readonly IRepository<SocialMedia> _repository;

    public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetSocialMediaQueryResult
        {
            SocialMediaID = x.SocialMediaID,
            Title = x.Title,
            Url = x.Url,
            Icon = x.Icon,
        }).ToList();
    }
}