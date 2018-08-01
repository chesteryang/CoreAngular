import { TestBed, inject } from '@angular/core/testing';
import { NgRedux } from '@angular-redux/store';
import { MockNgRedux } from '@angular-redux/store/testing';
import { EmployeeViewModelActions,
  CustomerViewModelActions,
  ProductViewModelActions } from '../adw/redux/actions';
import { ModelsService } from './models.service';

describe('ModelsService', () => {
  const spy1 = jasmine.createSpyObj('EmployeeViewModelActions', ['loadModel']);
  const spy2 = jasmine.createSpyObj('CustomerViewModelActions', ['loadModel']);
  const spy3 = jasmine.createSpyObj('ProductViewModelActions', ['loadModel']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        { provide: NgRedux, useFactory: MockNgRedux.getInstance },
        { provide: EmployeeViewModelActions, useValue: spy1},
        { provide: CustomerViewModelActions, useValue: spy2},
        { provide: ProductViewModelActions, useValue: spy3},
        ModelsService
      ]
    });
  });

  it('should be created', inject([ModelsService], (service: ModelsService) => {
    expect(service).toBeTruthy();
  }));
});
