using Food.Models;

namespace Food.Interface
{
    public interface IOrderHistoryRepastory
    {
        Task<List<OrderHistory>> GetAllOrderHistory();
    }
}