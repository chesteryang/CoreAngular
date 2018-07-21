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
    .subscribe(result => this.actions.loggedIn(result));
  }

  private postToServer(user: IUser): Observable<IEmployee> {
    return this.http.post<IEmployee>('/api/People/Validate', user)
    .pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: HttpErrorResponse) {
      // return an observable with a user-facing error message
    return throwError('Something bad happened; please try again later.');
  }
}
