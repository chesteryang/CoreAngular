import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ScaffoldContainerComponent } from './scaffold-container/scaffold-container.component';
import { CounterComponent } from '../counter/counter.component';
import { FetchDataComponent } from '../fetch-data/fetch-data.component';
import { CounterActions } from '../redux/actions';
import { SharedModule } from '../shared/shared.module';
import { TemplateFormComponent } from './template-form/template-form.component';
import { ReactiveFormComponent } from './reactive-form/reactive-form.component';
import { UserInfoActions } from './redux/actions';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot([
      { path: 'scaffold', component: ScaffoldContainerComponent }
    ]),
    FormsModule,
    ReactiveFormsModule,
    SharedModule
  ],
  declarations: [
    CounterComponent,
    FetchDataComponent,
    ScaffoldContainerComponent,
    TemplateFormComponent,
    ReactiveFormComponent
  ],
  providers: [
    CounterActions,
    UserInfoActions
  ]
})
export class ScaffoldModule { }
