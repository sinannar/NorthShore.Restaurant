import { Component, Injector, AfterViewInit, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { MenuServiceProxy, CreateFoodDto } from '@shared/service-proxies/service-proxies';

import { CreateFoodComponent } from 'app/restaurant/create-food/create-food.component';

@Component({
    templateUrl: './restaurant.component.html',
    animations: [appModuleAnimation()],
})
export class RestaurantComponent extends AppComponentBase {

    @ViewChild('createFoodModal') createTenantModal: CreateFoodComponent;
    // @ViewChild('editTenantModal') editTenantModal: EditTenantComponent;


    constructor(
        injector: Injector,
        private _menuService: MenuServiceProxy,
    ) {
        super(injector);
    }

    createFood(){
        this.createTenantModal.show();
    }

}
