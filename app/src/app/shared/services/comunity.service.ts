import { Injectable } from '@angular/core';
import {HttpClientModule, HttpClient} from '@angular/common/http'
import { Comunity } from '../models/Comunity.model';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ComunityService {

  constructor(private http: HttpClient) { }

 AddComunity(com:Comunity):Observable<boolean>
  {
    //enviroment es global
return this.http.post<boolean>(environment.url+ 'comunities/AddComunity', com)
  }

 getNumComunities():Observable<number>
  {
return this.http.get<number>(environment.url+ 'comunities/getNumComunities');
  }
}
