import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeViewListComponent } from '../adw/employee-vew-list/employee-view-list.component';
import { EmployeeViewModelActions, CustomerViewModelActions } from '../adw/redux/actions';
import { CustomerViewListComponent } from '../adw/customer-view-list/customer-view-list.component';
import { ModelsService } from './models.service';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    EmployeeViewListComponent, CustomerViewListComponent
  ],
  providers: [
    EmployeeViewModelActions, CustomerViewModelActions, ModelsService
  ],
  exports: [
    EmployeeViewListComponent, CustomerViewListComponent
  ]
})
export class SharedModule { }
