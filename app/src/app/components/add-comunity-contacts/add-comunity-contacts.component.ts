import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
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
allCity: City[]
myForm: FormGroup

  constructor(private comContactService: ComunityContactsService, private cityService: CityService, private router: Router) {

  


}
      
      
    
   

  ngOnInit(): void {
    this.cityService.getShowCity().subscribe(
      res=>this.allCity=res,
      err=> console.log(err) 
    )

    this.myForm = new FormGroup({
      contact: new FormControl('',Validators.required),
      phone: new FormControl('', Validators.required),
      mail: new FormControl('', Validators.required),
      cityCode: new FormControl('', Validators.required),
      about: new FormControl('', Validators.required),
      country: new FormControl('', Validators.required),
    });
  }
 
  addContacts() {
    if (this.myForm.valid) {
      const con = new Contacts(); 
      con.ContactName = this.myForm.controls.contact.value
      con.CityCode=this.myForm.controls.cityCode.value
      con.Aboutme = this.myForm.controls.about.value
      con.Country = this.myForm.controls.country.value;
      con.Email = this.myForm.controls.mail.value;
      con.PhoneNumber = this.myForm.controls.phone.value;
      this.comContactService.AddContacts(con).subscribe(
        res=> {console.log(res),
          this.router.navigate(['/directive']);
        },
        err=> console.log(err)  
      )
      this.router.navigate(['/directive']);
    }
  }
}
