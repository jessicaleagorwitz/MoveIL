import { Injectable } from '@angular/core';
import {HttpClientModule, HttpClient} from '@angular/common/http'
import { City } from '../models/City.model';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Contacts } from '../models/Contacts.model';
import { CityStatus } from '../models/CityStatus.model';

@Injectable({
  providedIn: 'root'
})
export class CityService {

 
  constructor(private http: HttpClient) { }

  addCity(city: City): Observable<boolean>
  {
 return this.http.post<boolean>(environment.url+'City/addCity',city)
  }
  //cities
  getShowCity():Observable<City[]>{
    return this.http.get<City[]>(environment.url+'City/getShowCity')
  }
  //cities
  getYourCity(cityCode):Observable<City>{
    return this.http.post<City>(environment.url+'City/getYourCity',parseInt(cityCode)) 
  }
  //your city
  getContacts(cityCode):Observable<Contacts[]>{
    return this.http.post<Contacts[]>(environment.url+'Contacts/getContacts',parseInt(cityCode)) 
  }
  // search your city
  getSearchCity(city :CityStatus):Observable<City[]>{
    return this.http.post<City[]>(environment.url+'City/getSearchCity',city) 
  }
  
}
