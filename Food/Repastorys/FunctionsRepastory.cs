using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.VisualBasic;

namespace Food.Repastorys;
public class FunctionsRepastory : IFunctionsRepastory
{
    private readonly AppDbContext _appDbContext;
    public FunctionsRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<Informations>> GetAllInformation()
    {
        var getid = await _appDbContext.Informations.ToListAsync();
        return getid;
    }



    public async Task<List<Lenguage>> GetLenguege()
    {
        var lis = await _appDbContext.lenguages.ToListAsync();
        return lis;
    }

    public async Task<List<OrderHistory>> GetOrderHistory()
    {
        var lis = await _appDbContext.OrderHistorie.ToListAsync();
        return lis;
    }

   
}
