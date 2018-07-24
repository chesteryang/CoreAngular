import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { NgReduxTestingModule, MockNgRedux } from '@angular-redux/store/lib/testing';
import { ReactiveFormComponent } from './reactive-form.component';
import { UserInfoActions } from '../redux/actions';
import { initUserInfo } from '../redux/reducers';

describe('ReactiveFormComponent', () => {
  let component: ReactiveFormComponent;
  let fixture: ComponentFixture<ReactiveFormComponent>;

  beforeEach(async(() => {
    const spy = jasmine.createSpyObj('UserInfoActions', ['saveInfo']);
    MockNgRedux.reset();
    const mockStore = MockNgRedux.getSubStore();
    const newsSelector = mockStore.getSelectorStub(['scaffoldState', 'userInfo']);
    newsSelector.next([{userInfo: initUserInfo}]);
    TestBed.configureTestingModule({
      imports: [
        ReactiveFormsModule,
        NgReduxTestingModule
      ],
      declarations: [ ReactiveFormComponent ],
      providers: [
        { provide: UserInfoActions, useValue: spy}
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReactiveFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
