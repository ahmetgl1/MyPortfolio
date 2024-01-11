using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioServer.Context;
using MyPortfolioServer.DTOs.Requests;
using MyPortfolioServer.Models;

namespace MyPortfolioServer.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class TechnologiesController : ControllerBase
{

    private readonly AppDbContext _appDbContext;

    public TechnologiesController(AppDbContext appDbContext)
    {

        _appDbContext = appDbContext;
    }



    [HttpPost]
    public IActionResult AddTechnologies(Guid userId, CreateRequestTechnologiesDto technologiesDto)
    {
        Technology technologies = _appDbContext.Technologies
            .Where(o => o.Name == technologiesDto.Name)
            .FirstOrDefault();

        if (technologies is null)
        {
            technologies = new Technology
            {
                Id = Guid.NewGuid(),
                Name = technologiesDto.Name,
                Status = "Backend", // Varsayılan bir durum ata
                URL = technologiesDto.URL,
                UserId = userId
            };

            _appDbContext.Add(technologies);
            _appDbContext.SaveChanges();
        }

        return BadRequest(new { Message = "Daha Önce Kayıt Edilmiş İsime sahip veri bulundu" });
    }




    [HttpGet("{userId}")]
    public IActionResult GetTechnologies(Guid userId)
    {
        var technologies = _appDbContext.Technologies.Where(t => t.UserId == userId).ToList();

        if (technologies.Count == 0)
        {
            return NotFound("Kullanıcıya ait teknoloji bulunamadı.");
        }

        return Ok(technologies);
    }







}
