import { Component, OnInit } from '@angular/core';
import { ComunityContacts } from 'src/app/shared/models/ComunityContacts.model';
import { ComunityContactsService } from 'src/app/shared/services/comunity-contacts.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  comContacts: ComunityContacts= new ComunityContacts();
  List: Array<ComunityContacts>
  constructor(private comContactService: ComunityContactsService) { 
    this.comContactService.getShowComunityContacts().subscribe(
      res=> this.List=res,
      err=>console.log(err)
      )
      
      
  }

  ngOnInit(): void {
    this.comContacts.ContactName="alberto";
    this.comContacts.DoesSpeakSpanish=true;
    this.comContacts.PhoneNumber="00-3456644"
    //this.AddComunityContacts();
    this.comContactService.getNumComunityContacts().subscribe(
      res=> console.log('num contacts'+res),
      err=>console.log(err)
      
      
    )
    this.comContactService.getShowComunityContacts().subscribe((con:Array<ComunityContacts>)=> this.List=con)
    //con push quizas
   // this.comContactService.getShowComunityContacts().subscribe((con:Array<ComunityContacts>)=> this.List.push(con.))
  // this.showContact();
  }
 // showContact() {
  //  this.comContactService.getShowComunityContacts()
   //   .subscribe((con: Array<ComunityContacts>)=> 
    //  this.contactList={
    //   ComunityCode : con.ComunityCode,
     //   ContactName:con.ContactName,
      //  Address:con.Address,
      //  BirthDate:con.BirthDate,
       // ContactCode:con.ContactCode,
       // DoesSpeakSpanish:con.DoesSpeakSpanish,
       // FamilyStatus:con.FamilyStatus,
       // PhoneNumber:con.PhoneNumber,
       // ProfessionCode:con.ProfessionCode,
       // SectorCode:con.SectorCode,
       // YearOfAlia:con.YearOfAlia
    //  }

    //  )
  
   // }
   


  AddComunityContacts(){
    this.comContactService.AddComunityContacts(this.comContacts).subscribe(
      res=>{console.log(res)},
      err=>{console.log(err)}
    )
  }
  
  


}