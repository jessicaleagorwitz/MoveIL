import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddRepresentanteComponent } from './add-representante.component';

describe('AddRepresentanteComponent', () => {
  let component: AddRepresentanteComponent;
  let fixture: ComponentFixture<AddRepresentanteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddRepresentanteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddRepresentanteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
