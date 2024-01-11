using MyPortfolioServer.Models;

namespace MyPortfolioServer.DTOs.Requests;

public class CreateProjectRequestDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string URL { get; set; }
    public List<CreateRequestUsedTechnologyDto> Technologies { get; set; }

}
