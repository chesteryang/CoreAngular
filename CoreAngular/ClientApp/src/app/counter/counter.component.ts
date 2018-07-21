import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { select, NgRedux } from '@angular-redux/store';
import { IStore } from '../redux/common';
import { CounterActions } from '../redux/actions';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;
  @select(['counterState', 'count']) readonly count$: Observable<number>;

  constructor(
    private ngRedux: NgRedux<IStore>,
    private actions: CounterActions) { }

  public incrementCounter() {
    this.currentCount++;
  }

  decrementCounter() {
    this.currentCount--;
  }

  increment() {
    this.ngRedux.dispatch(this.actions.increment());
  }

  decrement() {
    this.ngRedux.dispatch(this.actions.decrement());
  }
}
