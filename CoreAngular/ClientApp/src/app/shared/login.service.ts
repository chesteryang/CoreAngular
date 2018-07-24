import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { EmployeeActions } from '../adw/redux/actions';
import { IUser, IEmployee } from '../adw/redux/common';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(
    private http: HttpClient,
    private actions: EmployeeActions
  ) { }

  validate(loginId: string, password: string): void {
    this.actions.validating();
    this.postToServer({loginId, password})
    .subscribe(
      result => this.actions.loggedIn(result),
      error => this.actions.validationFailed(error));
  }

  logout(): void {
    this.actions.loggedOut();
  }

  private postToServer(user: IUser): Observable<IEmployee> {
    return this.http.post<IEmployee>('/api/People/Validate', user)
    .pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: HttpErrorResponse) {
    let message = 'Something bad happened; please try again later.';
    if (error.error instanceof ErrorEvent) {
      message = error.error.message;
    } else {
      switch (error.status) {
        case 404:
          message = 'Login Id not found';
          break;
        case 400:
          if (error.error instanceof Object) {
            let m = '';
            if (error.error.message) {
              m = error.error.message;
            } else {
              if (error.error.loginId) {
                m = error.error.loginId[0];
              }
              if (error.error.password) {
                m = m + (m === '' ? '' : ', ') + error.error.password[0];
              }
            }
            message = m;
          } else {
            message = error.error.message;
          }
          break;
      }
      // console.error(
      //   `Backend returned code ${error.status}, ` +
      //   `body was: ${error.error}`);
    }
    return throwError(message);
  }
}
