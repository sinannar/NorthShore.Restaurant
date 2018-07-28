import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { TenantServiceProxy, CreateTenantDto } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
    selector: 'create-food',
    templateUrl: './create-food.component.html'
})
export class CreateTenantComponent extends AppComponentBase {
}
