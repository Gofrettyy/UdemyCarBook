namespace UdemyCarBook.Application.Features.CQRS.Results.CategoryResult;

public class GetCategoryByIdQueryResult
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}