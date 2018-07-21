import { Component, OnInit, OnDestroy } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import {INews, IStore} from '../redux/common';
import { NgRedux, select, WithSubStore, PathSelector } from '@angular-redux/store';
import { NewsAction } from '../redux/actions';
import { Observable } from 'rxjs';
import { newsReducer } from '../redux/reducers';
@WithSubStore({
  basePathMethodName: 'getBasePath',
  localReducer: newsReducer
})
@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent implements OnInit, OnDestroy {
  isInitFocused: boolean;
  buttonClass: string;
  @select(['articles']) readonly news$: Observable<INews[]>;
  // @select(['newsState', 'articles']) readonly news$: Observable<INews[]>;
  // this works if without @WithSubStore

  constructor(
    private sanitizer: DomSanitizer,
    private ngRedux: NgRedux<IStore>,
    private action: NewsAction) {
    this.buttonClass = 'btn btn-outline-info btn-sm';
  }

  ngOnInit() {
    this.getNews('country=ca');
    this.isInitFocused = true;
  }

  ngOnDestroy() {
    this.action.disposeNews(this.ngRedux.dispatch);
  }

  getNews(query: string) {
    this.isInitFocused = false;
    this.action.loadNews(query, this.ngRedux.dispatch);
  }

  getUrl(oneNews: INews) {
    const url = oneNews && oneNews.urlToImage ? oneNews.urlToImage : 'assets/bg.jpeg';
    const safeUrl = this.sanitizer.bypassSecurityTrustStyle(`url('${url}')`);
    return safeUrl;
  }

  getBasePath(): PathSelector | null {
    return ['newsState'];
  }
}
