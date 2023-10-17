using Food.Dto_s;
using Food.Models;
using Microsoft.VisualBasic;

namespace Food.Interface;

public interface IInformationRepastory
{
    Task<List<Informations>> GetAllInformation();
    Task<Informations> GetIdInformation(int id);
    Task<InformationsDto> Add(InformationsDto information);
    Task<Informations> Update(int id, Informations informations);
    Task Delete(int id);
}
