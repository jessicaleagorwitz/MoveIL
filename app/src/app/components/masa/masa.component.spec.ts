import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MasaComponent } from './masa.component';

describe('MasaComponent', () => {
  let component: MasaComponent;
  let fixture: ComponentFixture<MasaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MasaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MasaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
