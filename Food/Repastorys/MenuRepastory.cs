using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Food.Repastorys
{
    public class MenuRepastory : IMenuRepastorycs
    {
        private readonly AppDbContext _appDbContext;
        public MenuRepastory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Foods>> GetFoods()
        {
            var lis = await _appDbContext.Foods.ToListAsync();
            return lis;
        }

        public async Task<List<Functions>> GetFunctions()
        {
            var lis = await _appDbContext.Functions.ToListAsync();
            return lis;

        }

        public async Task<List<Profile>> GetProfile()
        {
            var lis = await _appDbContext.profiles.ToListAsync();
            return lis;
        }
    }
}
