import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { select } from '@angular-redux/store';
import { IUserInfo } from '../redux/common';
import { UserInfoActions } from '../redux/actions';

@Component({
  selector: 'app-template-form',
  templateUrl: './template-form.component.html',
  styleUrls: ['./template-form.component.css']
})
export class TemplateFormComponent implements OnInit {

  @select(['scaffoldState', 'userInfo']) readonly userInfo$: Observable<IUserInfo>;
  constructor(private actions: UserInfoActions) { }

  ngOnInit() {
  }

  onSubmit({ value, valid }: { value: IUserInfo, valid: boolean }) {
    this.actions.saveInfo(value);
  }
}
