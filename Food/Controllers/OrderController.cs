using Food.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepastory _orderRepastory;
        public OrderController(IOrderRepastory orderRepastory)
        {
            _orderRepastory = orderRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrder() => Ok(await _orderRepastory.GetAllOrders());
     }
}
