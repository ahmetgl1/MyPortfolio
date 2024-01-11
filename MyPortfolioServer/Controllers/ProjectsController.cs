using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioServer.Context;
using MyPortfolioServer.DTOs.Requests;
using MyPortfolioServer.Models;

namespace MyPortfolioServer.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProjectsController : ControllerBase
{

    private readonly AppDbContext appDbContext;

    public ProjectsController(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }


    [HttpPost]
    public IActionResult CreateProject([FromBody] CreateProjectRequestDto projectDto)
    {
        if (projectDto == null)
        {
            return BadRequest("Invalid project data");
        }

        var newProject = new Project
        {
            Id = Guid.NewGuid(),
            Name = projectDto.Name,
            Description = projectDto.Description,
            URL = projectDto.URL,
            Technologies = projectDto.Technologies?.Select(t => new UsedTechnology
            {
                Id = Guid.NewGuid(),
                Name = t.Name
            }).ToList()
        };

        appDbContext.Projects.Add(newProject);
        appDbContext.SaveChanges();

        return Ok("Project created successfully");
    }


    [HttpGet]
    public IActionResult GetAllProjects()
    {
        var projects = appDbContext.Projects
            .Include(p => p.Technologies)
            .ToList();

        return Ok(projects);
    }








}
