using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UserService.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    
    [Route("sign-up")]
    public async Task<IActionResult> SignUp()
    {
        return Ok();
    }
}