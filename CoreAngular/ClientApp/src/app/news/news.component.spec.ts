import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { NgReduxTestingModule, MockNgRedux } from '@angular-redux/store/lib/testing';
import { NewsComponent } from './news.component';
import { NewsAction } from '../redux/actions';

describe('NewsComponent', () => {
  let element: HTMLElement;
  let component: NewsComponent;
  let fixture: ComponentFixture<NewsComponent>;
  let mockNewsAction: jasmine.SpyObj<NewsAction>;

  beforeEach(async(() => {
    const spy = jasmine.createSpyObj('NewsAction', ['loadNews', 'disposeNews']);
    MockNgRedux.reset();
    const mockStore = MockNgRedux.getSubStore();
    const newsSelector = mockStore.getSelectorStub(['newsState', 'articles']);
    newsSelector.next([{source: {name: ''}}]);

    TestBed.configureTestingModule({
      declarations: [ NewsComponent ],
      imports: [ NgReduxTestingModule ],
      providers: [ {provide: NewsAction, useValue: spy} ]
    })
    .compileComponents();
   }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewsComponent);
    mockNewsAction = TestBed.get(NewsAction);
    component = fixture.componentInstance;
    element = fixture.debugElement.nativeElement;
    fixture.detectChanges();
  });

  it('should create an instance', () => {
    expect(component).toBeTruthy();
    expect(mockNewsAction.loadNews).toHaveBeenCalled();
  });

  it('should pump test news to news$', async(() => {
    component.news$.subscribe(news => {
      expect(news.length).toEqual(1);
    });
  }));

  afterEach(() => {
    element.remove();
  });
});
