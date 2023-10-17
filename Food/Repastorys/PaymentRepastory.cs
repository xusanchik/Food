using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Food.Repastorys;
public class PaymentRepastory : IPaymentRepastory
{
    private readonly AppDbContext _appDbContext;
    public PaymentRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<List<Payment>> GetAllPayment()
    {
        var lis = await _appDbContext.payments.ToListAsync();
        return lis;
    }
}
