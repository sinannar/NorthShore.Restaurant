﻿using NorthShore.Restaurant.Restaurant.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NorthShore.Restaurant.Restaurant
{
    public interface IRestaurantAppService
    {
        Task CreateFood(CreateFoodDto request);
        Task EditFood(EditFoodDto request);
        Task DeleteFood(long requestId);
        List<ShowFoodDto> ListFoods();

        Task CreateMenu(CreateMenuDto request);
        Task DeleteMenu(long requestId);
        List<ShowMenuDto> ListMenus();

        Task<List<ShowFoodDto>> ListFoodsInMenu(long menuId);
        Task<List<ShowFoodDto>> ListFoodsNotInMenu(long menuId);
    }
}
