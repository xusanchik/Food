using Food.Models;
using Microsoft.VisualBasic;
using Food.Dto_s;

namespace Food.Interface;

public interface IFunctionsRepastory
{
    Task<List<Informations>> GetAllInformation();
    Task<List<Lenguage>> GetLenguege();
    Task<List<OrderHistory>> GetOrderHistory();

}
