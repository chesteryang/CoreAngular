import { Injectable } from '@angular/core';
import { NgRedux } from '@angular-redux/store';
import { IStore } from '../redux/common';
import { EmployeeViewModelActions, CustomerViewModelActions } from '../adw/redux/actions';

@Injectable({
  providedIn: 'root'
})
export class ModelsService {
  constructor(
    private ngRedux: NgRedux<IStore>,
    private employeeActions: EmployeeViewModelActions,
    private customerActions: CustomerViewModelActions) { }

  loadModels() {
    this.employeeActions.loadModel(this.ngRedux.dispatch);
    this.customerActions.loadModel(this.ngRedux.dispatch);
  }
}
