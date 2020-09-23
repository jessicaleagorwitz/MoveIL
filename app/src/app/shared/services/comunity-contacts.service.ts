import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ComunityContacts } from '../models/ComunityContacts.model';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ComunityContactsService {
  //donde?????????????????? se pone!???????
  private comunityContact= new Array<ComunityContacts>();
  constructor(private http: HttpClient) { }

  getNumComunityContacts():Observable<number> {
 return this.http.get<number>(environment.url+'comunityContacts/getNumComunityContacts')
  }
//como se recibe una lista?
  getShowComunityContacts():Observable<Array<ComunityContacts>>{
    return this.http.get<Array<ComunityContacts>>(environment.url+'comunityContacts/getShowComunityContacts')
  }

  AddComunityContacts(comunityContacts: ComunityContacts): Observable<boolean>
  {
    return this.http.post<boolean>(environment.url + 'comunityContacts/AddComunityContacts', comunityContacts);
  }

}
