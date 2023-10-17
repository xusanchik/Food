using Food.Models;

namespace Food.Interface;
public interface IRegistrationRepastory
{
    Task<List<Registration>> GetAllRegistation();
    Task  Delete(int id);
}
