using Abp.Authorization;
using Abp.Domain.Repositories;
using NorthShore.Restaurant.Restaurant.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NorthShore.Restaurant.Restaurant
{
    public class MenuAppService : RestaurantAppServiceBase, IMenuAppService
    {
        private IRepository<Food, long> _foodRepository;
        public MenuAppService(
                IRepository<Food, long> foodRepository
            )
        {
            _foodRepository = foodRepository;
        }

        public async Task CreateFood(CreateFoodDto request)
        {
            await Task.Run(() => {});
            //throw new NotImplementedException();
        }
    }
}
