using Food.Data;
using Food.Dto_s;
using Food.Interface;
using Food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepastory _userRepastory;
        public UserController(IUserRepastory userRepastory)
        {
            _userRepastory = userRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers() => Ok(await _userRepastory.GetAllUsers());
        [HttpGet("Menu")]
        public async Task<IActionResult> GetMenu() => Ok (await _userRepastory.Menu());
        [HttpPost]
        public async Task<IActionResult> Registration([FromForm]RegistrationDto registration) => Ok(await _userRepastory.Registration(registration));
    }
}
