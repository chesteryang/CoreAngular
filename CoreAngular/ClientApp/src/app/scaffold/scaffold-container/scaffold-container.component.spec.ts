import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ScaffoldContainerComponent } from './scaffold-container.component';

describe('ScaffoldContainerComponent', () => {
  let component: ScaffoldContainerComponent;
  let fixture: ComponentFixture<ScaffoldContainerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ScaffoldContainerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ScaffoldContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
