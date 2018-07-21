import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdwContainerComponent } from './adw-container.component';

describe('AdwContainerComponent', () => {
  let component: AdwContainerComponent;
  let fixture: ComponentFixture<AdwContainerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdwContainerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdwContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
