using Microsoft.AspNetCore.Mvc;
using Socialize.DB;
using Socialize.Services.BusinessInterface;

namespace Socialize.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var res = await _userService.GetAll();
            return Ok(res);
        }
    }
}
