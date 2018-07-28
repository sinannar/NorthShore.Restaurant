import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { MenuServiceProxy, CreateFoodDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './restaurant.component.html',
    animations: [appModuleAnimation()],
    providers: [MenuServiceProxy]
})
export class RestaurantComponent extends AppComponentBase {

    constructor(
        injector: Injector,
        private _menuService: MenuServiceProxy,
    ) {
        super(injector);
    }

    callApi() {
        this._menuService.createFood(new CreateFoodDto()).subscribe(() => {
            console.log('FIRST API CALL FROM FE');
        });
    }

}
