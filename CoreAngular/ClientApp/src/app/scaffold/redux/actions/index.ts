import { Injectable } from '@angular/core';
import { NgRedux } from '@angular-redux/store';
import { IStore } from '../../../redux/common';
import { IUserInfo } from '../common';

@Injectable()
export class UserInfoActions {
  static MODEL_SAVED = 'MODEL_SAVED';
  constructor(private ngRedux: NgRedux<IStore>) {}

  saveInfo(info: IUserInfo): void {
    this.ngRedux.dispatch({
      type: UserInfoActions.MODEL_SAVED,
      payload: info
    });
  }
}
