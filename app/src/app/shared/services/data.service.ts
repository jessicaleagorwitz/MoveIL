import { Injectable } from '@angular/core';
import { ComunityContacts } from '../models/ComunityContacts.model';

@Injectable({
  providedIn: 'root'
})
export class DataService {
private comunityContact= new Array<ComunityContacts>();
  constructor() { }

  
}
