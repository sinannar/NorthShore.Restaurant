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
        private IRepository<Food, long> _foodRepository { get; set; }

        public MenuAppService(
            IRestaurantManager restaurantManager,
            IRepository<Food, long> foodRepository
            )
        {
            _restaurantManager = restaurantManager;
            _foodRepository = foodRepository;
        }

        public async Task CreateFood(CreateFoodDto requestDto)
        {
            var adapter = new CreateFoodAdapter();
            await _restaurantManager.CreateFood(adapter.Transform(requestDto));
        }

        public async Task EditFood(EditFoodDto request)
        { 
            var entity = _foodRepository.Get(request.Id);
            if (entity != null)
            {
                var adapter = new EditFoodAdapter();
                await _restaurantManager.EditFood(adapter.Transform(request, entity));
            }
            else
            {
                throw new Exception("Given food is not found to delete");
            }
        }

        public async Task DeleteFood(DeleteFoodDto request)
        {
            Food entity = await _foodRepository.GetAsync(request.Id);
            if (entity != null)
            {
                await _restaurantManager.DeleteFood(entity);
            }
            else
            {
                throw new Exception("Given food is not found to delete");
            }
        }

        public List<ShowFoodDto> ListFoods()
        {
            var adapter = new ListFoodAdapter();
            var list = _restaurantManager.ListFood();
            return adapter.Transform(list);
        }
    }
}
