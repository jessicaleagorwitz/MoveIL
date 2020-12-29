import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { City } from '../models/City.model';
import { Distrito } from '../models/Distrito.model';

@Injectable({
  providedIn: 'root'
})
export class DistritoService {

  constructor(private http: HttpClient) { }
   
     getDistritoCode(code):Observable<City[]> {
       return this.http.post<City[]>(environment.url+'Distrito/getDistritoCode',code)
       }
  getDistrito():Observable<Distrito[]>{
    return this.http.get<Distrito[]>(environment.url+'Distrito/getDistrito')
  }

  
}
