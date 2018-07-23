import { Action, Reducer, combineReducers } from 'redux';
import { CounterActions, NewsAction } from '../actions';
import { ICounterState, INewsState, IStore, INews } from '../common';
import { adventureworksReducers, initAdventureworksState } from '../../adw/redux/reducers';
import { scaffoldReducer, initScaffoldState } from '../../scaffold/redux/reducers';

const initCounterState: ICounterState = {
  count: 0,
};

const counterReducer: Reducer<ICounterState> = (state = initCounterState, action: Action) => {
  switch (action.type) {
    case CounterActions.INCREMENT: return { count: state.count + 1 };
    case CounterActions.DECREMENT: return { count: state.count - 1 };
    default: return state;
  }
};

const initNewsState: INewsState = {
  articles: []
};

export const newsReducer: Reducer<INewsState> =
(state = initNewsState, action: {type: string, payload: INews[]}) => {
  switch (action.type) {
    case NewsAction.NEWS_LOADED:
      return { articles: action.payload };
    case NewsAction.NEWS_DISPOSED:
      return {articles: action.payload };
    default:
      return state;
  }
};

export const rootReducer = combineReducers<IStore>({
  counterState: counterReducer,
  newsState: newsReducer,
  adventureworksState: adventureworksReducers,
  scaffoldState: scaffoldReducer
});

export const initialState: IStore = {
  counterState: initCounterState,
  newsState: initNewsState,
  adventureworksState : initAdventureworksState,
  scaffoldState: initScaffoldState
};

