import { TestBed, inject } from '@angular/core/testing';
import { LoginService } from './login.service';
import { HttpClient } from '@angular/common/http';
import { EmployeeActions } from '../adw/redux/actions';

describe('LoginService', () => {
  beforeEach(() => {
    const spy = jasmine.createSpyObj('EmployeeActions', ['loggedOut']);
    const httpSpy = jasmine.createSpyObj('HttpClient', ['get']);
    TestBed.configureTestingModule({
      providers: [
        LoginService,
        { provide: HttpClient, useValue: httpSpy},
        { provide: EmployeeActions, useValue: spy}
      ]
    });
  });

  it('should be created', inject([LoginService], (service: LoginService) => {
    expect(service).toBeTruthy();
  }));
});
