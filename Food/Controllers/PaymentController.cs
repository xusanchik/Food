using Food.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepastory _paymentRepastory;
        public PaymentController(IPaymentRepastory paymentRepastory)
        {
            _paymentRepastory = paymentRepastory;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPayment() => Ok(await _paymentRepastory.GetAllPayment());
    }
}
