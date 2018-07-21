import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { AdwContainerComponent } from './adw-container/adw-container.component';
import { PersonActions } from './redux/actions';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot([
      { path: 'adventure-works', component: AdwContainerComponent }
    ]),
    SharedModule
  ],
  providers: [
    PersonActions
  ],
  declarations: [AdwContainerComponent]
})
export class AdwModule { }
