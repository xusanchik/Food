using Food.Models;

namespace Food.Interface;
public interface IPaymentRepastory
{
    Task<List<Payment>> GetAllPayment();
}
