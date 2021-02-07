import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddNewComunityComponent } from './add-new-comunity.component';

describe('AddNewComunityComponent', () => {
  let component: AddNewComunityComponent;
  let fixture: ComponentFixture<AddNewComunityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddNewComunityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddNewComunityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
