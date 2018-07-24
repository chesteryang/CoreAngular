import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { select } from '@angular-redux/store';
import { IUserInfo } from '../redux/common';
import { UserInfoActions } from '../redux/actions';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-reactive-form',
  templateUrl: './reactive-form.component.html',
  styleUrls: ['./reactive-form.component.css']
})
export class ReactiveFormComponent implements OnInit {
  user: FormGroup;

  @select(['scaffoldState', 'userInfo']) readonly userInfo$: Observable<IUserInfo>;

  constructor(
    private actions: UserInfoActions,
    private fb: FormBuilder) { }

  ngOnInit() {
    this.userInfo$.subscribe((info) => {
      this.user = this.fb.group({
        name: [info.name],
        phone: [info.phone],
        email: [info.email]
      });
    });
  }

  onSubmit({ value, valid }: { value: IUserInfo, valid: boolean }) {
    this.actions.saveInfo(value);
  }
}
