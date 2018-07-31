import { Injectable } from '@angular/core';
import { NgRedux } from '@angular-redux/store';
import { IStore } from '../redux/common';
import { EmployeeViewModelActions, CustomerViewModelActions, ProductViewModelActions } from '../adw/redux/actions';

@Injectable({
  providedIn: 'root'
})
export class ModelsService {
  constructor(
    private ngRedux: NgRedux<IStore>,
    private employeeActions: EmployeeViewModelActions,
    private customerActions: CustomerViewModelActions,
    private productActions: ProductViewModelActions) { }

  loadModels() {
    this.employeeActions.loadModel(this.ngRedux.dispatch);
    this.customerActions.loadModel(this.ngRedux.dispatch);
    this.productActions.loadModel(this.ngRedux.dispatch);
  }
}
