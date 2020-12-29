import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { YourCityComponent } from './your-city.component';

describe('YourCityComponent', () => {
  let component: YourCityComponent;
  let fixture: ComponentFixture<YourCityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ YourCityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(YourCityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
