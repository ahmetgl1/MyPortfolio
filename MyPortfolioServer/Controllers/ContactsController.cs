using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioServer.Context;
using MyPortfolioServer.DTOs.Requests;
using MyPortfolioServer.Models;

namespace MyPortfolioServer.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ContactsController : ControllerBase
{

    private readonly AppDbContext _appDbContext;


    public ContactsController(AppDbContext _appDbContext)
    {
        this._appDbContext = _appDbContext;
    }


    [HttpPost]
    public IActionResult Create(CreateContactRequestDto requestDto)
    {
        Contact existingContact = _appDbContext.Contacts
            .FirstOrDefault(o => o.Name == requestDto.Name);

        if (existingContact != null)
        {
            return BadRequest(new { Message = "Bu isimde bir kişi zaten var." });
        }

        Contact newContact = new Contact
        {
            Id = Guid.NewGuid(),
            Name = requestDto.Name,
            URL = requestDto.URL
        };

        _appDbContext.Contacts.Add(newContact);
        _appDbContext.SaveChanges();

        return NoContent();
    }

    [HttpGet]
    public IActionResult GetAllContacts()
    {
        List<Contact> contacts = _appDbContext.Contacts.ToList();
        return Ok(contacts);
    }







}
