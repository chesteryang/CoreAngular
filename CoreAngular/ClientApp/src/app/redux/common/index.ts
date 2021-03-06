import { IAdventureworksState } from '../../adw/redux/common';
import { IScaffoldState } from '../../scaffold/redux/common';

export interface IStore {
  counterState: ICounterState
  newsState: INewsState
  adventureworksState: IAdventureworksState
  scaffoldState: IScaffoldState
}

export interface ICounterState {
  count: number;
}

export interface INewsState {
  articles: INews[]
}

export interface INewsSource {
    id: string
    name: string
}

export interface INews {
  source: INewsSource
  author: string
  title: string
  description: string
  url: string
  urlToImage: string
  publishedAt: Date
}
