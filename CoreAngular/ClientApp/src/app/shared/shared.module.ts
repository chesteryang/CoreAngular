import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeViewListComponent } from '../adw/employee-vew-list/employee-view-list.component';
import { EmployeeViewModelActions,
  CustomerViewModelActions,
  EmployeeActions } from '../adw/redux/actions';
import { CustomerViewListComponent } from '../adw/customer-view-list/customer-view-list.component';
import { ModelsService } from './models.service';
import { LoginComponent } from '../adw/login/login.component';
import { LoginService } from './login.service';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    EmployeeViewListComponent,
    CustomerViewListComponent,
    LoginComponent
  ],
  providers: [
    EmployeeViewModelActions,
    CustomerViewModelActions,
    EmployeeActions,
    ModelsService,
    LoginService
  ],
  exports: [
    EmployeeViewListComponent,
    CustomerViewListComponent,
    LoginComponent
  ]
})
export class SharedModule { }
