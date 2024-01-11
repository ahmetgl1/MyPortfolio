namespace MyPortfolioServer.Models;

public class UserDetail
{

    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Resume { get; set; }

}
