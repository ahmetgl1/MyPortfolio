namespace MyPortfolioServer.Models;

public class Technology
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public string URL { get; set; }
    public Guid UserId { get; set; }
}
