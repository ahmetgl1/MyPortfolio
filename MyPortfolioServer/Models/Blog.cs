namespace MyPortfolioServer.Models;

public class Blog
{
    public int Id { get; set; }
    //public Guid UserId { get; set; }
    //public User User { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public string İmageURL { get; set; }
    public string PostURL { get; set; }
    public short Duration { get; set; }
    public DateTime CreateAt { get; set; }
    public List<BlogTag> BlogTags { get; set; }


}
