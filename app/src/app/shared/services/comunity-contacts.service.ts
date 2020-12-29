import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Contacts } from '../models/Contacts.model';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Recommendation } from '../models/Recommendation.model';
import { User } from '../models/User.model';
@Injectable({
  providedIn: 'root'
})
export class ComunityContactsService {
  //donde?????????????????? se pone!???????
  private comunityContact= new Array<Contacts>();
  constructor(private http: HttpClient) { }

 // getNumComunityContacts():Observable<number> {
/// return this.http.get<number>(environment.url+'comunityContacts/getNumComunityContacts')
 // }
//como se recibe una lista?
  //getShowComunityContacts():Observable<Array<Contacts>>{
  //  return this.http.get<Array<Contacts>>(environment.url+'comunityContacts/getShowComunityContacts')
 // }

 // AddComunityContacts(comunityContacts: Contacts): Observable<boolean>
 // {
 //   return this.http.post<boolean>(environment.url + 'comunityContacts/AddComunityContacts', comunityContacts);
 // }

 getRecomendations():Observable<Recommendation[]> {
   return this.http.get<Recommendation[]>(environment.url+'Recommendation/getShowRecommendation')
   }
  
    getUserCode(code):Observable<User> {
      return this.http.post<User>(environment.url+'user/getUserCode',code)
      }
      
    getUser():Observable<User[]> {
    return this.http.get<User[]>(environment.url+'user/getUser')
    }
}
