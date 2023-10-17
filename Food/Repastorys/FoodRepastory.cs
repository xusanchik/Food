using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;
using Food.Dto_s;
using Microsoft.VisualBasic;
using Mapster;

namespace Food.Repastorys;
public class FoodRepastory : IFoodRepastory
{
    private readonly AppDbContext _appDbContext;
    public FoodRepastory(AppDbContext appDb)
    {
        _appDbContext = appDb;
    }
    public async Task<FoodDto> Add(FoodDto foodDto)
    {
        var info = foodDto.Adapt<Foods>();
        _appDbContext.Foods.Add(info);
        await _appDbContext.SaveChangesAsync();
        return foodDto;
    }

    public async Task Delete(int id)
    {
        var getidd = await _appDbContext.Foods.FindAsync(id);
        _appDbContext.Foods.Remove(getidd);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<List<Foods>> GEtALLFoods()
    {
        var lis = await _appDbContext.Foods.ToListAsync();
        return lis;
    }
}
