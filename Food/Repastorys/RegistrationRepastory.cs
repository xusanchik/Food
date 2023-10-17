using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Food.Repastorys;
public class RegistrationRepastory : IRegistrationRepastory
{
    private readonly AppDbContext _appDbContext;
    public RegistrationRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task Delete(int id)
    {
        var getid = await _appDbContext.registrations.FirstAsync();
        _appDbContext.registrations.Remove(getid);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<List<Registration>> GetAllRegistation()
    {
        var lis = await _appDbContext.registrations.ToListAsync();
        return lis;
    }
}
