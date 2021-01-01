import { Injectable } from '@angular/core';
import {HttpClientModule, HttpClient} from '@angular/common/http'
import { Comunity } from '../models/Comunity.model';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { PersonalStatus } from '../models/PersonalStatus.model';
import { Representante } from '../models/Representante';
import { Sector } from '../models/Sector.model';

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
//serach your comunity
  getComunity(personal:PersonalStatus):Observable<Comunity[]>
  {
    console.log(personal);
    
return this.http.post<Comunity[]>(environment.url+'comunities/getComunities',personal);
  }
// get your comunity 
getYourComunity(code):Observable<Comunity>
{ 
return this.http.post<Comunity>(environment.url+'comunities/getYourComunity',parseInt(code));
}
getRepresentante(code):Observable<Representante>
{
  return this.http.post<Representante>(environment.url+'comunities/getRepresentante',parseInt(code));
}

getSector(code):Observable<Sector>
{
  return this.http.post<Sector>(environment.url+'comunities/getSector',parseInt(code));
}
}
