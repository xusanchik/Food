using Food.Dto_s;
using Food.Models;

namespace Food.Interface;
public interface IFoodRepastory
{
    Task<List<Foods>> GEtALLFoods();
    Task<FoodDto> Add(FoodDto foods);
    Task Delete(int id);
}
