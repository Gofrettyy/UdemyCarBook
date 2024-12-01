namespace UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries;

public class GetAboutByIdQuery
{
    public GetAboutByIdQuery(int id)
    {
        Id = id;     // bir nesne örneği üzerinden bu id çağıracağım için constructor oluşturduk.
    }

    public int Id { get; set; }
}