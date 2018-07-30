import { Component, Injector, AfterViewInit, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { MenuServiceProxy, ShowFoodDto } from '@shared/service-proxies/service-proxies';

import { CreateFoodComponent } from 'app/restaurant/create-food/create-food.component';

@Component({
    templateUrl: './restaurant.component.html',
    animations: [appModuleAnimation()],
})
export class RestaurantComponent extends AppComponentBase {

    @ViewChild('createFoodModal') createTenantModal: CreateFoodComponent;
    // @ViewChild('editTenantModal') editTenantModal: EditTenantComponent;

    foods: ShowFoodDto[];

    constructor(
        injector: Injector,
        private _menuService: MenuServiceProxy,
    ) {
        super(injector);
        this.list();
    }

    list() {
        this._menuService.listFoods().subscribe(result => {
            this.foods = result;
        });
    }

    createFood() {
        this.createTenantModal.show();
    }

    editFood(food: ShowFoodDto) {
        this.notify.warn('This service (editFood) is not available yet');
    }

    deleteFood(food: ShowFoodDto) {
        this.notify.warn('This service (deleteFood) is not available yet');
    }


}
