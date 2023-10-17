using Food.Interface;
using Food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Food.Dto_s;


namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepastory _profile;
        public ProfileController(IProfileRepastory profile)
        {
            _profile = profile;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProfil() => Ok(await _profile.GetAllProfil());
        [HttpGet("Name")]
        public async Task<IActionResult> GetAProfil([FromForm]int id) => Ok(await _profile.GetProfils(id));
        [HttpPost]
        public async Task<IActionResult> CreateProfil([FromForm]ProfileDto profile) => Ok(await _profile.Create(profile));
        [HttpPut]
        public async Task<IActionResult> UpdateProfil( int id, Profile profile) => Ok(await _profile.Update(id, profile));
        [HttpDelete]
        public async Task<IActionResult> DeleteProfil([FromForm] int id)
        {
            await _profile.Delete(id);
            return Ok();
        }

    }
}
