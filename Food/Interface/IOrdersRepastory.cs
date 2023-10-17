using Food.Models;

namespace Food.Interface;
public interface IOrderRepastory
{
    Task<List<Orders>> GetAllOrders();
}
