namespace MyPortfolioServer.DTOs.Requests;

public class CreateBlogRequestDto
{

    public string Title { get; set; }
    public string Summary { get; set; }
    public string İmageURL { get; set; }
    public string PostURL { get; set; }
    public short Duration { get; set; }
    public List<int> TagIds { get; set; }


}
