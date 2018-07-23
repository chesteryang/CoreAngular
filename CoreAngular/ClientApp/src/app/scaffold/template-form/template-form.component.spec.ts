import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { NgReduxTestingModule, MockNgRedux } from '@angular-redux/store/lib/testing';
import { TemplateFormComponent } from './template-form.component';
import { UserInfoActions } from '../redux/actions';
import { initUserInfo } from '../redux/reducers';

describe('TemplateFormComponent', () => {
  let component: TemplateFormComponent;
  let fixture: ComponentFixture<TemplateFormComponent>;

  beforeEach(async(() => {
    const spy = jasmine.createSpyObj('UserInfoActions', ['saveInfo']);
    MockNgRedux.reset();
    const mockStore = MockNgRedux.getSubStore();
    const newsSelector = mockStore.getSelectorStub(['scaffoldState', 'userInfo']);
    newsSelector.next([{userInfo: initUserInfo}]);
    TestBed.configureTestingModule({
      imports: [
        FormsModule,
        NgReduxTestingModule
      ],
      declarations: [ TemplateFormComponent ],
      providers: [
        { provide: UserInfoActions, useValue: spy}
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TemplateFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
