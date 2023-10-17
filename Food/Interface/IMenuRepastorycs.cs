using Food.Models;

namespace Food.Interface;
public interface IMenuRepastorycs
{
    Task<List<Foods>> GetFoods();
    Task<List<Functions>> GetFunctions();
    Task<List<Profile >> GetProfile();


}
