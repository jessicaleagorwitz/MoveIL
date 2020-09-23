import { Injectable } from '@angular/core';
import {HttpClientModule, HttpClient} from '@angular/common/http'
import { City } from '../models/City.model';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CityService {

 
  constructor(private http: HttpClient) { }

  addCity(city: City): Observable<boolean>
  {
 return this.http.post<boolean>(environment.url+'City/addCity',city)
  }
}
