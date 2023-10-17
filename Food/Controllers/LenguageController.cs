using Food.Interface;
using Food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Food.Dto_s;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LenguageController : ControllerBase
    {
        private readonly ILenguageRepastory _lenguageRepastory;
        public LenguageController(ILenguageRepastory lenguageRepastory)
        {
            _lenguageRepastory = lenguageRepastory;
        }
        [HttpGet]
        public async Task<IActionResult > GetAllLenguage() => Ok(await _lenguageRepastory.GetAllLenguage());
        [HttpGet("id")]
        public async Task<IActionResult> GetIdLenguage(int id) => Ok(await _lenguageRepastory.GetIdLenguage(id));
        [HttpPost]
        public async Task<IActionResult> AddLenguage([FromForm]LenguageDto lenguage) => Ok(await _lenguageRepastory.Add(lenguage));
        [HttpPut]
        public IActionResult UpdateLenguage([FromForm]int id, Lenguage lenguageDto) => Ok(_lenguageRepastory.UpdateLenguage(id , lenguageDto));
        [HttpDelete]
        public async Task<IActionResult> DeleteLenguage([FromForm]int id)
        {
            await _lenguageRepastory.Delete(id);
            return Ok();
        }
    }
}
