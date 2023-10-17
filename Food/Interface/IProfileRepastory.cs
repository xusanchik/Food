using Food.Models;
using Food.Dto_s;

namespace Food.Interface;
public interface IProfileRepastory
{
    Task<List<Profile>> GetAllProfil();
    Task<Profile> GetProfils(int id);
    Task<ProfileDto> Create(ProfileDto profile);
    Task <Profile> Update(int id, Profile profile);
    Task Delete (int id);
}
