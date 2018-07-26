import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { MenuServiceProxy, CreateFoodDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './restaurant.component.html',
    animations: [appModuleAnimation()]
})
export class RestaurantComponent extends AppComponentBase {

    constructor(injector: Injector, private menuServiceProxy: MenuServiceProxy) {
        super(injector);
    }

    callApi() {

        this.menuServiceProxy.createFood(new CreateFoodDto()).subscribe(() => {


        });
    }

}
