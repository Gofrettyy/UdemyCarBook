using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;

public class GetSocialMediaByIdQueryHandler :IRequestHandler<GetSocialMediaByIdQuery,GetSocialMediaByIdQueryResult>
{
    private readonly IRepository<SocialMedia> _repository;

    public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
    {
     var value = await _repository.GetByIdAsync(request.Id);
      return new GetSocialMediaByIdQueryResult
      {
        SocialMediaID = value.SocialMediaID,
        Title = value.Title,
        Icon = value.Icon,
        Url = value.Url,
      }; 
    }
}