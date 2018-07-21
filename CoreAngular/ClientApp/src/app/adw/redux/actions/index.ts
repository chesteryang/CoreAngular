import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { NgRedux } from '@angular-redux/store';
import { Dispatch } from 'redux';
import { IEmployeeViewModel, IPerson, ICustomerViewModel, IUser, IEmployee } from '../common';
import { IStore } from '../../../redux/common';


@Injectable()
export class EmployeeViewModelActions {
  static MODEL_LOADED = 'EmployeeViewModel_LOADED';
  constructor(private http: HttpClient) {}

  loadModel(dispatch: Dispatch): void {
    this.http.get<IEmployeeViewModel[]>('/api/People/GetEmployeeViewModel')
      .subscribe(result => {
        dispatch({
          type: EmployeeViewModelActions.MODEL_LOADED,
          payload: result
        });
      });
  }
}

@Injectable()
export class PersonActions {
  static PERSON_LOADED = 'PERSON_LOADED';
  constructor(private http: HttpClient) {}

  loadPerson(id: number, dispatch: Dispatch): void {
    this.http.get<IPerson>('/api/People/GetEmployeeDetail/' + id)
      .subscribe(result => {
        dispatch({
          type: PersonActions.PERSON_LOADED,
          payload: result
        });
      });
  }
}

@Injectable()
export class CustomerViewModelActions {
  static MODEL_LOADED = 'CustomerViewModel_LOADED';
  constructor(private http: HttpClient) {}

  loadModel(dispatch: Dispatch): void {
    this.http.get<ICustomerViewModel[]>('/api/People/GetCustomerViewModel')
      .subscribe(result => {
        dispatch({
          type: CustomerViewModelActions.MODEL_LOADED,
          payload: result
        });
      });
  }
}

@Injectable()
export class EmployeeActions {
  static VALIDATING_STARTING = 'VALIDATING_STARTING';
  static VALIDATING_FAILED = 'VALIDATING_FAILED';
  static LOGGED_IN = 'LOGGED_IN';
  static LOGGED_OUT = 'LOGGED_OUT';

  constructor(private ngRedux: NgRedux<IStore>) {}

  loggedOut(): void {
    this.ngRedux.dispatch({type: EmployeeActions.LOGGED_OUT});
  }

  loggedIn(employee: IEmployee): void {
    this.ngRedux.dispatch({type: EmployeeActions.LOGGED_IN, payload: employee});
  }

  validating(): void {
    this.ngRedux.dispatch({type: EmployeeActions.VALIDATING_STARTING});
  }

  validationFailed(errorMessage: string): void {
    this.ngRedux.dispatch({type: EmployeeActions.VALIDATING_FAILED, payload: errorMessage});
  }
}
