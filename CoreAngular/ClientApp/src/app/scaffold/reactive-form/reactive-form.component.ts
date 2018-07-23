import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { select } from '@angular-redux/store';
import { IUserInfo } from '../redux/common';
import { UserInfoActions } from '../redux/actions';

@Component({
  selector: 'app-reactive-form',
  templateUrl: './reactive-form.component.html',
  styleUrls: ['./reactive-form.component.css']
})
export class ReactiveFormComponent implements OnInit {

  @select(['scaffoldState', 'userInfo']) readonly userInfo$: Observable<IUserInfo>;
  constructor(private actions: UserInfoActions) { }

  ngOnInit() {
  }

  onSubmit({ value, valid }: { value: IUserInfo, valid: boolean }) {
    this.actions.saveInfo(value);
  }
}
