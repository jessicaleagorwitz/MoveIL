import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddComunityComponent } from './add-comunity.component';

describe('AddComunityComponent', () => {
  let component: AddComunityComponent;
  let fixture: ComponentFixture<AddComunityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddComunityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddComunityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
