using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;
using Food.Dto_s;
using Mapster;

namespace Food.Repastorys;
public class ProfileRepastory : IProfileRepastory
{
    private readonly AppDbContext _appDbContext;
    public  ProfileRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<ProfileDto> Create(ProfileDto profile)
    {
        var profileDto = profile.Adapt<Profile>();
        _appDbContext.profiles.Add(profileDto);
        await _appDbContext.SaveChangesAsync();
        return profile;
    }

    public async Task Delete(int id)
    {
        var getname = await _appDbContext.registrations.FindAsync(id);
        _appDbContext.registrations.Remove(getname);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<List<Profile>> GetAllProfil()
    {
        var getProfil = await _appDbContext.profiles.ToListAsync();
        return getProfil;
    }

    public async Task<Profile> GetProfils(int id)
    {
        var getid = await _appDbContext.profiles.FindAsync(id);
        return getid;
    }

    public async Task<Profile> Update(int id, Profile profile)
    {
        var prof = await _appDbContext.profiles.FindAsync(id);
        prof.Name = profile.Name;
        _appDbContext.profiles.Update(prof);
        await _appDbContext.SaveChangesAsync();
        return prof;

    }
}
