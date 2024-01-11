using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioServer.Context;
using MyPortfolioServer.DTOs.Requests;
using MyPortfolioServer.Models;

namespace MyPortfolioServer.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BlogsController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public BlogsController(AppDbContext _appDbContext)
    {
        this._appDbContext = _appDbContext;
    }



    [HttpPost]
    public IActionResult Create(CreateBlogRequestDto requestDto)
    {


        Blog blog = new()
        {
            Title = requestDto.Title,
            CreateAt = DateTime.Now,
            Duration = requestDto.Duration,
            PostURL = requestDto.PostURL,
            İmageURL = requestDto.İmageURL,
            Summary = requestDto.Summary,

        };

        List<BlogTag> blogTags = new List<BlogTag>();

        if (requestDto.TagIds != null && requestDto.TagIds.Any())
        {
            foreach (var tagId in requestDto.TagIds)
            {
                
                BlogTag blogTag = new BlogTag
                {
                    Blog = blog,
                    TagId = tagId
                };
                blogTags.Add(blogTag);
            }
        }

       
        blog.BlogTags = blogTags;

        _appDbContext.Blogs.Add(blog);
        _appDbContext.SaveChanges();

        return NoContent();

    }


    [HttpGet("{pageSize}")]
    public IActionResult GetAllBlogsAndTags(int pageSize)
    {
        //var startIndex = (pageNumber - 1) * pageSize;

        var blogsWithTags = _appDbContext.Blogs
            .Include(blog => blog.BlogTags)
                .ThenInclude(blogTag => blogTag.Tag)
            
            .Take(pageSize)
            .Select(blog => new
            {
                Id = blog.Id,
                Title = blog.Title,
                Summary = blog.Summary,
                Duration = blog.Duration,
                Publisher = "Ahmet Fatih Güzeller",
                CreateDate = blog.CreateAt,
                PostURL = blog.PostURL,
                ImageURL = blog.İmageURL,
                Tags = blog.BlogTags.Select(blogTag => new
                {
                    TagId = blogTag.Tag.Id,
                    TagName = blogTag.Tag.Name
                }).ToList()
            })
            .ToList();

        return Ok(blogsWithTags);
    }


}
