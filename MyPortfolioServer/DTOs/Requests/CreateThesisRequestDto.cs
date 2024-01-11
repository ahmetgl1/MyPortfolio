namespace MyPortfolioServer.DTOs.Requests;

public class CreateThesisRequestDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string AuthorName { get; set; }
    public string URL { get; set; }
}
