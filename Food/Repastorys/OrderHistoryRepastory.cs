using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Food.Repastorys
{
    public class OrderHistoryRepastory : IOrderHistoryRepastory
    {
        private readonly AppDbContext _appDbContext;
        public OrderHistoryRepastory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<OrderHistory>> GetAllOrderHistory()
        {
            var lis = await _appDbContext.OrderHistorie.ToListAsync();
            return lis;
        }
    }
}
