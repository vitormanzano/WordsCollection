using Microsoft.AspNetCore.Mvc;
using WordsCollection.Dtos.User;

namespace WordsCollection.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SignUp(SignUpUserDto user)
    {
        return Ok();
    }
}