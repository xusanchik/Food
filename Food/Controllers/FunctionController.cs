using Food.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunctionController : ControllerBase
    {
        private readonly IFunctionsRepastory _functionsRepastory;
        public FunctionController(IFunctionsRepastory functionsRepastory)
        {
            _functionsRepastory = functionsRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetLenguage() => Ok(await _functionsRepastory.GetLenguege());
        [HttpGet("order")]
        public async Task<IActionResult> GetORderHistory() => Ok(await _functionsRepastory.GetOrderHistory());
        [HttpGet("Informations")]
        public async Task<IActionResult> GetInformation() => Ok(await _functionsRepastory.GetAllInformation());

    }
}
