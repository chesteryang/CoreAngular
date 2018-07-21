import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { NavbarMenuComponent } from './navbar-menu.component';
import { APP_BASE_HREF } from '@angular/common';

@Component({
  template: '<h1>empty</h1>'
})
class EmptyComponent {}

describe('NavbarMenuComponent', () => {
  let element: HTMLElement;
  let component: NavbarMenuComponent;
  let fixture: ComponentFixture<NavbarMenuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NavbarMenuComponent, EmptyComponent ],
      imports: [RouterModule.forRoot([
        { path: '', component: EmptyComponent, pathMatch: 'full' },
        { path: 'news', component: EmptyComponent },
        { path: 'counter', component: EmptyComponent },
        { path: 'fetch-data', component: EmptyComponent }
      ])],
      providers: [ {provide: APP_BASE_HREF, useValue : '/' } ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NavbarMenuComponent);
    component = fixture.componentInstance;
    element = fixture.debugElement.nativeElement;
    fixture.detectChanges();
  });

  it('should create an instance', () => {
    expect(component).toBeTruthy();
  });

  afterEach(() => {
    element.remove();
  });
});
