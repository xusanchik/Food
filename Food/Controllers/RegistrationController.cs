using Food.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationRepastory _registration;
        public RegistrationController([FromForm]IRegistrationRepastory registration)
        {
            _registration = registration;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRegistration() => Ok(await _registration.GetAllRegistation());
        [HttpDelete]
        public async Task<IActionResult> DeleteRegistr([FromForm]int id)
        {
            await _registration.Delete(id);
            return Ok();
        }
    }
}
