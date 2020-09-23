import { TestBed } from '@angular/core/testing';

import { ComunityContactsService } from './comunity-contacts.service';

describe('ComunityContactsService', () => {
  let service: ComunityContactsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ComunityContactsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
