﻿namespace MyPortfolioServer.Models;

public class Project
{

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string URL { get; set; }
    public List<UsedTechnology> Technologies { get; set; }

}
