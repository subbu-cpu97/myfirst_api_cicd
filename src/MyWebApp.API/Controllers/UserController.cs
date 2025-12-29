using Microsoft.AspNetCore.Mvc;
using MyWebApp.Application.Interfaces;
using MyWebApp.Application.DTOs;

namespace MyWebApp.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    [Route("create")]
    public IActionResult CreateUser([FromBody] UserDto userDto)
    {
        var result = _userService.CreateUser(userDto.Username, userDto.Password);
        return Ok(result);
    }

    [HttpPost]
    [Route("validate")]
    public IActionResult ValidateUser([FromBody] UserDto userDto)
    {
        var isValid = _userService.ValidateUser(userDto.Username, userDto.Password);
        return Ok(isValid);
    }
}