using Microsoft.AspNetCore.Mvc;
using Socialize.Contracts.User;
using Socialize.DB;
using Socialize.Services.BusinessInterface;

namespace Socialize.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _userService.GetAll();
            return Ok(res);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrUpdate(CreateOrUpdateUserReq req)
        {
            try
            {
                var res = await _userService.CreateOrUpdate(req);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
