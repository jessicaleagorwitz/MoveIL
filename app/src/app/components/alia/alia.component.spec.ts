import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AliaComponent } from './alia.component';

describe('AliaComponent', () => {
  let component: AliaComponent;
  let fixture: ComponentFixture<AliaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AliaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AliaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
