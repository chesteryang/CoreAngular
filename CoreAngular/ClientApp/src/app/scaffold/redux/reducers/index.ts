import { Reducer, combineReducers } from 'redux';
import {IUserInfo, IScaffoldState } from '../common';
import { UserInfoActions } from '../actions';

export const initUserInfo: IUserInfo = { name: '', phone: '', email: ''};
export const initScaffoldState: IScaffoldState = { userInfo: initUserInfo };

export const userInfoReducer: Reducer<IUserInfo> =
  (state = initUserInfo, action: {type: string, payload: IUserInfo} ) => {
   switch (action.type) {
     case UserInfoActions.MODEL_SAVED:
      return action.payload;
      default:
      return state;
   }
};

export const scaffoldReducer = combineReducers<IScaffoldState>({
  userInfo: userInfoReducer
});

