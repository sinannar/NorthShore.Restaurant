import { Component, Injector, AfterViewInit, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { RestaurantServiceProxy, ShowFoodDto } from '@shared/service-proxies/service-proxies';

import { CreateFoodComponent } from 'app/restaurant/create-food/create-food.component';
import { EditFoodComponent } from 'app/restaurant/edit-food/edit-food.component';

@Component({
    templateUrl: './restaurant.component.html',
    animations: [appModuleAnimation()],
})
export class RestaurantComponent extends AppComponentBase {


    constructor(
        injector: Injector,
    ) {
        super(injector);
    }
}
