using Abp.Authorization;
using Abp.Domain.Repositories;
using NorthShore.Restaurant.Restaurant.Adapters;
using NorthShore.Restaurant.Restaurant.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NorthShore.Restaurant.Restaurant
{
    public class MenuAppService : RestaurantAppServiceBase, IMenuAppService
    {
        private IRestaurantManager _restaurantManager { get; set; }

        public MenuAppService(
            IRestaurantManager restaurantManager
            )
        {
            _restaurantManager = restaurantManager;
        }

        public async Task CreateFood(CreateFoodDto requestDto)
        {
            var adapter = new CreateFoodAdapter();
            await _restaurantManager.CreateFood(adapter.Transform(requestDto));
        }

        public async Task DeleteFood(DeleteFoodDto request)
        {
            await _restaurantManager.DeleteFood(request.Id);
        }


        public List<ShowFoodDto> ListFoods()
        {
            var adapter = new ListFoodAdapter();
            var list = _restaurantManager.ListFood();
            return adapter.Transform(list);
        }
    }
}
