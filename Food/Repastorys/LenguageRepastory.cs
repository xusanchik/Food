using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;
using Food.Dto_s;
namespace Food.Repastorys;
using Mapster;

public class LenguageRepastory : ILenguageRepastory
{
    private readonly AppDbContext _appDbContext;
    public LenguageRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<LenguageDto> Add(LenguageDto lenguage)

    {
        var leng = lenguage.Adapt<Lenguage>();
        _appDbContext.lenguages.Add(leng);
        await _appDbContext.SaveChangesAsync();
        return lenguage;
    }

    public async Task Delete(int id)
    {
        var getid = await _appDbContext.lenguages.FindAsync(id);
        _appDbContext.lenguages.Remove(getid);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<List<Lenguage>> GetAllLenguage()
    {
        var lis = await _appDbContext.lenguages.ToListAsync();
        return lis;
    }

    public async Task<Lenguage> GetIdLenguage(int id)
    {
        var getid = await _appDbContext.lenguages.FindAsync(id);
        return getid;

    }

    public async Task UpdateLenguage(int id, Lenguage lenguage)
    {
        var getid = await _appDbContext.lenguages.FindAsync(id);
        getid.name = lenguage.name;
        _appDbContext.Update(getid);
        await _appDbContext.SaveChangesAsync();


    
    }
}
