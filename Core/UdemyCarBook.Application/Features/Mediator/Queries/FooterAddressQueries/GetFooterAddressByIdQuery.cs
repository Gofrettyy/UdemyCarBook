using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.FooterAddressResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FooterAddressQueries;

public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQuery>, IRequest<GetFooterAddressByIdQueryResult>
{
    public GetFooterAddressByIdQuery(int id)  
    {
        Id = id;
    }

    public int Id { get; set; }
}