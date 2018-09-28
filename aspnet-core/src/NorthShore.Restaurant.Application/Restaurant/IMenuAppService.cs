using NorthShore.Restaurant.Restaurant.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NorthShore.Restaurant.Restaurant
{
    public interface IMenuAppService
    {
        Task CreateFood(CreateFoodDto request);
        Task DeleteFood(DeleteFoodDto request);
        List<ShowFoodDto> ListFoods();
    }
}
