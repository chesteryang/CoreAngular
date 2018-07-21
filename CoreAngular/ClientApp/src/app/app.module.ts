import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavbarMenuComponent } from './navbar-menu/navbar-menu.component';

import { NgReduxModule, NgRedux, DevToolsExtension } from '@angular-redux/store';
import { CounterActions, NewsAction } from './redux/actions';
import { rootReducer, initialState } from './redux/reducers';
import { NewsComponent } from './news/news.component';
import { IStore } from './redux/common';
import { AdwModule } from './adw/adw.module';
import { ScaffoldModule } from './scaffold/scaffold.module';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavMenuComponent,
    NavbarMenuComponent,
    NewsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    NgReduxModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'news', component: NewsComponent }
    ]),
    AdwModule,
    ScaffoldModule
  ],
  providers: [
    CounterActions,
    NewsAction
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
  constructor(ngRedux: NgRedux<IStore>, devTools: DevToolsExtension) {
    const storeEnhancers = devTools.isEnabled() ? [ devTools.enhancer() ] : [];
    // Tell @angular-redux/store about our rootReducer and our initial state.
    // It will use this to create a redux store for us and wire up all the
    // events.
    ngRedux.configureStore(
      rootReducer,
      initialState,
      [],
      storeEnhancers);
  }
}
