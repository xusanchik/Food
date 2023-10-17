using Food.Dto_s;
using Food.Interface;
using Food.Models;
using Food.Repastorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly IInformationRepastory _informationRepastory;
        public InformationController(IInformationRepastory informationRepastory)
        {
            _informationRepastory = informationRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GEtAllInformations() => Ok(await _informationRepastory.GetAllInformation());
        [HttpGet("id")]
        public async Task<IActionResult> GEtIdInformations([FromForm] int id) => Ok(await _informationRepastory.GetIdInformation(id));
        [HttpPut]
        public async Task<IActionResult> UpdateInformations([FromForm] int id, Informations information) => Ok(await _informationRepastory.Update(id, information));
        [HttpPost]
        public async Task<IActionResult> Add([FromForm]InformationsDto information) => Ok(await _informationRepastory.Add(information));
        [HttpDelete]
        public async Task<IActionResult> DeleteInformations([FromForm] int id)
        {
            await _informationRepastory.Delete(id);
            return Ok();
        }


    }
}
