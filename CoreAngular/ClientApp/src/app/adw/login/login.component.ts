import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { select } from '@angular-redux/store';
import { IEmployeeState} from '../redux/common';
import { LoginService } from '../../shared/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  @select(['adventureworksState', 'employeeState']) readonly employeeState$: Observable<IEmployeeState>;

  constructor(private loginService: LoginService) { }

  ngOnInit() {
  }

  onSubmit({ value, valid }: { value: any, valid: boolean }) {
    this.loginService.validate(value.loginId, value.password);
  }

  onLogout() {
    this.loginService.logout();
  }
}
