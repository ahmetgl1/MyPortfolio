using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioServer.Context;
using MyPortfolioServer.DTOs.Requests;
using MyPortfolioServer.Models;

namespace MyPortfolioServer.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ThesisesController : ControllerBase
{

    private readonly AppDbContext _appDbContext;

    public ThesisesController(AppDbContext _appDbContext)
    {

        this._appDbContext = _appDbContext;
    }

    [HttpPost]
    public IActionResult Create(CreateThesisRequestDto requestDto)
    {

        Thesis? currentThesis = _appDbContext.Thesises
            .Where(o => o.URL == requestDto.URL)
            .FirstOrDefault();

        if(currentThesis is  null) {

            currentThesis = new()
            {
                Name = requestDto.Name,
                URL = requestDto.URL,
                Id = Guid.NewGuid(),
                AuthorName = requestDto.AuthorName,
                Description = requestDto.Description,
                ImageUrl = requestDto.ImageUrl,
            };


            _appDbContext.Add(currentThesis);
            _appDbContext.SaveChanges();
        
            
            
            return Ok();
        }

        return BadRequest(new { Message = "Daha Önce Oluşturulmuş" });


    }

    [HttpGet]
    public IActionResult GetAllThesises()
    {
        var thesises = _appDbContext.Thesises.ToList();
        return Ok(thesises);
    }













}
