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
import { ProductViewComponent } from '../adw/product-view/product-view.component';
import { ProductViewListComponent } from '../adw/product-view-list/product-view-list.component';

@NgModule({
  imports: [
    FormsModule,
    CommonModule
  ],
  declarations: [
    EmployeeViewListComponent,
    CustomerViewListComponent,
    ProductViewComponent,
    ProductViewListComponent,
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
    ProductViewComponent,
    ProductViewListComponent,
    LoginComponent
  ]
})
export class SharedModule { }
