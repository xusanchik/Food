using Food.Models;
using Food.Dto_s;
namespace Food.Interface
{
    public interface ILenguageRepastory
    {
        Task<List<Lenguage>> GetAllLenguage();
        Task<Lenguage> GetIdLenguage(int id);
        Task<LenguageDto> Add(LenguageDto lenguage);
        Task  UpdateLenguage(int id, Lenguage lenguage);
        Task  Delete(int id);

    }
}
