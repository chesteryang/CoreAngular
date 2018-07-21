import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeViewListComponent } from '../adw/employee-vew-list/employee-view-list.component';
import { EmployeeViewModelActions, CustomerViewModelActions } from '../adw/redux/actions';
import { CustomerViewListComponent } from '../adw/customer-view-list/customer-view-list.component';
import { ModelsService } from './models.service';
import { LoginComponent } from '../adw/login/login.component';

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
    EmployeeViewModelActions, CustomerViewModelActions, ModelsService
  ],
  exports: [
    EmployeeViewListComponent,
    CustomerViewListComponent,
    LoginComponent
  ]
})
export class SharedModule { }
