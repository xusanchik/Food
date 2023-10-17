using Food.Interface;
using Food.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Food.Dto_s;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodRepastory _foodRepastory;
        public FoodController(IFoodRepastory foodRepastory)
        {
             _foodRepastory = foodRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFoods() => Ok(await _foodRepastory.GEtALLFoods());
        [HttpDelete]
        public async Task<IActionResult> DeleteFood([FromForm] int id)
        {
            await _foodRepastory.Delete(id);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Addfood([FromForm]FoodDto food) => Ok(await _foodRepastory.Add(food));




    }
}
