import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { log } from '../models/login.model';
import { Recommendation } from '../models/Recommendation.model';
import { User } from '../models/User.model';


@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  getAllUsers():Observable<User[]>
  {
  
return this.http.get<User[]>(environment.url+ 'user/getAllUsers')
  }

 //add user register
  addUser(user:User):Observable<boolean>
  {
 
return this.http.post<boolean>(environment.url+ 'user/AddUser', user)
  }

  //chack mail already exist register
  SingInCheckUser(mail):Observable<boolean>{
    return this.http.post<boolean>(environment.url+ 'user/SingInCheckUser', mail)
  }

  //check login
 checkUser(log: log):Observable<User>
  {
  
return this.http.post<User>(environment.url+ 'user/LogIn',log)
  }

  addRecommendation(rec: Recommendation):Observable<boolean>
  {
  
return this.http.post<boolean>(environment.url+ 'recommendation/addRecommendation',rec)
  }
}
