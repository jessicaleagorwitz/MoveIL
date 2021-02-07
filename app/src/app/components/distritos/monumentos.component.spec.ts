import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MonumentosComponent } from './monumentos.component';

describe('MonumentosComponent', () => {
  let component: MonumentosComponent;
  let fixture: ComponentFixture<MonumentosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MonumentosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MonumentosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
