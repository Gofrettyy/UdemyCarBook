namespace UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResults;

public class GetSocialMediaByIdQueryResult
{
    public int SocialMediaID { get; set; }
    public string Title { get; set; }
    public string Icon { get; set; }
    public string Url { get; set; }
}