using Food.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepastorycs _menuRepastorycs;
        public MenuController(IMenuRepastorycs menuRepastorycs)
        {
            _menuRepastorycs = menuRepastorycs;
        }
        [HttpGet]
        public async Task<IActionResult> GetFoods() => Ok(await _menuRepastorycs.GetFoods());

        [HttpGet("Fontions")]
        public async Task<IActionResult> GetFUnctions() => Ok(await _menuRepastorycs.GetFunctions());

        [HttpGet("Profile")]
        public async Task<IActionResult> GetProfile() => Ok(await _menuRepastorycs.GetProfile());


    }
}
