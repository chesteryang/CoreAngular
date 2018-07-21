import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeViewListComponent } from './employee-view-list.component';

describe('EmployeeVewListComponent', () => {
  let element: HTMLElement;
  let component: EmployeeViewListComponent;
  let fixture: ComponentFixture<EmployeeViewListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EmployeeViewListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeViewListComponent);
    component = fixture.componentInstance;
    element = fixture.debugElement.nativeElement;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  afterEach(() => {
    element.remove();
  });
});
