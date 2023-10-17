using Food.Data;
using Food.Dto_s;
using Food.Interface;
using Food.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Food.Repastorys;
public class UserRepastory : IUserRepastory
{
    private readonly AppDbContext _appDbContext;
    public UserRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<List<User>> GetAllUsers()
    {
        var users = await _appDbContext.Users.ToListAsync();
        return users;
    }

    public async Task<List<Menu>> Menu()
    {
       var Menus = await _appDbContext.Menus.ToListAsync();
        return Menus;
    }

    public async Task<RegistrationDto> Registration(RegistrationDto registration)
    {
        var user = registration.Adapt<Registration>();

        await _appDbContext.AddRangeAsync(user);
        await _appDbContext.SaveChangesAsync();
        return registration;

    }
}
