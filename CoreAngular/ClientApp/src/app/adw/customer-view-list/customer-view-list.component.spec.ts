import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerViewListComponent } from './customer-view-list.component';

describe('CustomerViewListComponent', () => {
  let element: HTMLElement;
  let component: CustomerViewListComponent;
  let fixture: ComponentFixture<CustomerViewListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CustomerViewListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomerViewListComponent);
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
