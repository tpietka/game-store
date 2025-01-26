﻿using Microsoft.AspNetCore.Mvc;
using UserManagement.Dto;
using UserManagement.Entities;
using UserManagement.Services;
using UserManagement.ViewModels;

namespace GameStore.Controllers;
[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserSignUpService _signUpService;

    public UserController(IUserSignUpService signUpService)
    {
        _signUpService = signUpService ?? throw new ArgumentNullException(nameof(signUpService));
    }

    // GET api/<UserController>
    [HttpGet()]
    public ActionResult<UserDto> Get()
    {
        var user = new UserDto(new UserName("Bob", "Rob"), new PhoneNumber("123456789"), new Email("bobrob@bobrob.br"));
        return Ok(user);
    }

    // POST api/<UserController>
    [HttpPost]
    public ActionResult Save([FromBody] UserSignUpVm user)
    {
        if(!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            return BadRequest(errors);
        }

        _signUpService.SignUp(user);

        return Ok("User successfully created.");
    }
}
