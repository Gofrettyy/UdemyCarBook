using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FeatureQuery;

public class GetFeatureQuery :IRequest<List<GetFeatureQueryResult>> // Mediatrda IRequesttan miras alıyoruz ve diyoruz ki sen bana bir liste olarak GetFeatureQueryResult Dön
{
    
}