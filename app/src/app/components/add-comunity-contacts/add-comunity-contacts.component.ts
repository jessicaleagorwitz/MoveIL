import { Component, OnInit } from '@angular/core';
import { City } from 'src/app/shared/models/City.model';
import { Contacts } from 'src/app/shared/models/Contacts.model';
import { CityService } from 'src/app/shared/services/city.service';
import { ComunityContactsService } from 'src/app/shared/services/comunity-contacts.service';

@Component({
  selector: 'app-add-comunity-contacts',
  templateUrl: './add-comunity-contacts.component.html',
  styleUrls: ['./add-comunity-contacts.component.css']
})
export class AddComunityContactsComponent implements OnInit {
comContacts: Contacts= new Contacts();
contactList; //Array<ComunityContacts> = new Array<ComunityContacts>();
allCities: City[]
List: Array<Contacts>
  constructor(private comContactService: ComunityContactsService, private cityService: CityService) {
  //  this.comContactService.getShowComunityContacts().subscribe(
///res=> this.List=res,
//err=>console.log(err)
//)
this.cityService.getShowCity().subscribe(
  res=> this.allCities=res,
  err=> console.log(err)
  
)

}
      
      
    
   

  ngOnInit(): void {
    this.comContacts.ContactName="alberto";

    this.comContacts.PhoneNumber="00-3456644"
    //this.AddComunityContacts();
  //  this.comContactService.getNumComunityContacts().subscribe(
   //   res=> console.log('num contacts'+res),
   //   err=>console.log(err)
      
      
   // )
  //  this.comContactService.getShowComunityContacts().subscribe((con:Array<Contacts>)=> this.List=con)
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
   


 // AddComunityContacts(){
  //  this.comContactService.AddComunityContacts(this.comContacts).subscribe(
  //    res=>{console.log(res)},
  //    err=>{console.log(err)}
  //  )
 // }
  
}
