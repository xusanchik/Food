using Food.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderHistoryController : ControllerBase
    {
        private readonly IOrderHistoryRepastory _orderHistoryRepastory;
        public OrderHistoryController(IOrderHistoryRepastory orderHistoryRepastory)
        {
            _orderHistoryRepastory = orderHistoryRepastory;
        }
        [HttpGet]
        public async Task<IActionResult > GetAllOrderHistory() => Ok(await _orderHistoryRepastory.GetAllOrderHistory());
    }
}
