import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { EmployeeViewListComponent } from '../adw/employee-vew-list/employee-view-list.component';
import { EmployeeViewModelActions,
  CustomerViewModelActions,
  EmployeeActions,
  ProductViewModelActions} from '../adw/redux/actions';
import { CustomerViewListComponent } from '../adw/customer-view-list/customer-view-list.component';
import { ModelsService } from './models.service';
import { LoginComponent } from '../adw/login/login.component';
import { LoginService } from './login.service';

@NgModule({
  imports: [
    FormsModule,
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
    ProductViewModelActions,
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
