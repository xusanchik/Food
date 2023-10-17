using Food.Dto_s;
using Food.Models;

namespace Food.Interface;

public interface IUserRepastory
{
    Task<List<User>> GetAllUsers();
    Task<RegistrationDto> Registration(RegistrationDto registration);
    Task<List<Menu>> Menu();
}
