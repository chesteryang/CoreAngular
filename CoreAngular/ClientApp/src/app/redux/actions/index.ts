import { Injectable} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Action, Dispatch } from 'redux';
import { INewsState } from '../common';

@Injectable()
export class CounterActions {
  static INCREMENT = 'INCREMENT';
  static DECREMENT = 'DECREMENT';

  increment(): Action {
    return { type: CounterActions.INCREMENT };
  }

  decrement(): Action {
    return { type: CounterActions.DECREMENT };
  }
}

@Injectable()
export class NewsAction {
  static NEWS_LOADED = 'NEWS_LOADED';
  static NEWS_DISPOSED = 'NEWS_DISPOSED';

  constructor(private http: HttpClient) {}

  loadNews(query: string, dispatch: Dispatch): void {
    this.http.get<INewsState>
     (`https://newsapi.org/v2/top-headlines?${query}&apiKey=adf0927cbd624a20abb1517d8b56114b`)
      .subscribe(result => {
        dispatch({
          type: NewsAction.NEWS_LOADED,
          payload: result.articles
        });
       });
  }

  disposeNews(dispatch): void {
    dispatch({
      type: NewsAction.NEWS_DISPOSED,
      payload: []
    });
  }
}
