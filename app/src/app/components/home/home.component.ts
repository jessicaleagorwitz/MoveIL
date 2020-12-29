import { Component, OnInit } from '@angular/core';
import { City } from 'src/app/shared/models/City.model';
import { Contacts } from 'src/app/shared/models/Contacts.model';
import { Recommendation } from 'src/app/shared/models/Recommendation.model';
import { User } from 'src/app/shared/models/User.model';
import { ComunityContactsService } from 'src/app/shared/services/comunity-contacts.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  
  List: Recommendation[]
  ListRan: Recommendation[]
user:User[]
u:User
name;
lastname;
email;
code;
 
 
  constructor(private comContactService: ComunityContactsService) { 
  //  this.comContactService.getShowComunityContacts().subscribe(
   //   res=> this.List=res,
   //   err=>console.log(err)
   //   )
      this.comContactService.getRecomendations().subscribe(
        res=>{this.List=res 
          console.log(this.List);
          
          this.List.forEach(q=> this.comContactService.getUserCode(q.UserCode).subscribe(
            res=> {q.user=res
              console.log(this.List);
              
            }
          ))
        },
        err=> console.log(err)
        
      )
   //   this.ListRan= this.List.
      
  }

  ngOnInit(): void {
    
   this.comContactService.getUser().subscribe(
     res=> this.user=res,
     err=> console.log(err)
     
   )
   for (var i = 0; i < this.List.length; i++) {
    this.comContactService.getUserCode(this.List[i].UserCode).subscribe(
      res=> {this.name=res.FirstName;
      this.lastname=res.LastName;
      this.email=res.Email;
      this.code= res.UserCode;
    }
     
      )
}
   console.log(this.user);
   
    //this.AddComunityContacts();
  //  this.comContactService.getNumComunityContacts().subscribe(
   //   res=> console.log('num contacts'+res),
    //  err=>console.log(err)
    //   )
  //  this.comContactService.getShowComunityContacts().subscribe((con:Array<ComunityContacts>)=>{ this.List=con; console.log(this.List)})
    
    //con push quizas
  // this.comContactService.getShowComunityContacts().subscribe((con:Array<ComunityContacts>)=> this.List.push(con.))
   //this.showContact();
  }
 

  
  


}