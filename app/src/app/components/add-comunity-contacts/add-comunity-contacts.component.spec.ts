import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddComunityContactsComponent } from './add-comunity-contacts.component';

describe('AddComunityContactsComponent', () => {
  let component: AddComunityContactsComponent;
  let fixture: ComponentFixture<AddComunityContactsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddComunityContactsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddComunityContactsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
