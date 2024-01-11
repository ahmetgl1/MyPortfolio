using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolioServer.Context;
using MyPortfolioServer.DTOs.Requests;
using MyPortfolioServer.DTOs.Responses;
using MyPortfolioServer.Models;

namespace MyPortfolioServer.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class UsersController : ControllerBase
{

    private readonly AppDbContext appDbContext;
    public UsersController(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }


    [HttpPost]
    public IActionResult Create(CreateUserRequestDto requestDto)
    {

        User user = appDbContext.Users.FirstOrDefault(o => o.Email == requestDto.Email);

        if (user is not null)
        {

            return BadRequest(new { Message = "Böyle Bir Kullanıcı Daha Önce Kayıt Olmuş" });
        }

        user = new()
        {
            Id = Guid.NewGuid(),
            Email = requestDto.Email,
            FirstName = requestDto.FirstName,
            LastName = requestDto.LastName,
            PhoneNumber = requestDto.PhoneNumber,
           
        };

        UserDetail userDetail = new()
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            Title = requestDto.Title,
            Description = requestDto.Description,
            Resume = requestDto.Resume
        };


        appDbContext.Users.Add(user);
        appDbContext.UserDetails.Add(userDetail);

        appDbContext.SaveChanges();


        User? createdUser = appDbContext.Users.FirstOrDefault(o => o.Email == requestDto.Email);

        if (createdUser is not null)
        {
            CreatedResponseDto responseDto = new CreatedResponseDto
            {
                FirstName = createdUser.FirstName,
                LastName = createdUser.LastName,
                PhoneNumber = createdUser.PhoneNumber,
                Email = createdUser.Email,
                Title = userDetail.Title,
                Description = userDetail.Description
            };

            return Ok(responseDto);

        }


        return BadRequest(new { Message = "Kullanıcı oluşturulamadı." });

    }

     
    [HttpGet("{email}")]
    public IActionResult GetUser(string email)
    {


        User? user = appDbContext.Users
            .Include(o => o.UserDetail)
            .FirstOrDefault(o => o.Email == email);

        if (user is null)
        {

            return BadRequest(new { Message = "Error !" });
        };



        CreatedResponseDto responseDto = new CreatedResponseDto
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            PhoneNumber = user.PhoneNumber,
            Email = user.Email,
            Title = user.UserDetail.Title,
            Description = user.UserDetail.Description,
            Resume = user.UserDetail.Resume
        };
        return Ok(responseDto);



    }




    //CRUD EKLENECEK !!!!!



};
