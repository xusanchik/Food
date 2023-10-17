using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Food.Repastorys;

public class OrdersRepastory  :IOrderRepastory
{

    private readonly AppDbContext _appDbContext;
    public OrdersRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<List<Orders>> GetAllOrders()
    {
        var lis = await _appDbContext.Orders.ToListAsync();
        return lis;
    }
}
