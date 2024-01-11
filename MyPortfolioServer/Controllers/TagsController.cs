using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioServer.Context;
using MyPortfolioServer.DTOs.Requests;
using MyPortfolioServer.Models;

namespace MyPortfolioServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TagsController : ControllerBase
{

    private readonly AppDbContext _appDbContext;

    public TagsController(AppDbContext _appDbContext)
    {
     
        this._appDbContext = _appDbContext;
        
    }

    [HttpPost]
    public IActionResult Create(CreateRequestTagDto tagRequest)
    {


        Tag? tag =  _appDbContext.Tags
            .Where(o => o.Name == tagRequest.Name)
            .FirstOrDefault();


        if(tag is not null)
        {
            return BadRequest(new { Message = "Daha Önce Oluşturulmuş Tag Bulunuyor" });

        }


        tag = new()
        {
            Name = tagRequest.Name
        };
        _appDbContext.Tags .Add(tag);
        _appDbContext.SaveChanges();


        return NoContent();

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Tag>>> GetTags()
    {
        return await _appDbContext.Tags.ToListAsync();
    }







}



