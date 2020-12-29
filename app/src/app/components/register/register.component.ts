import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DataService } from 'src/app/shared/services/data.service';
import { User } from 'src/app/shared/models/User.model';
import { PasswordValidator, UsernameService } from 'src/app/validators/valid';
import { LoginService } from 'src/app/shared/services/login.service';
import { Router } from '@angular/router';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  myform:FormGroup;
 

  //private comUser: UserService, private comCountry:CountryService
  constructor(private dataService: DataService, private login : LoginService, private router: Router) { }

  ngOnInit(): void {
    this.myform= new FormGroup({
     email: new FormControl('',Validators.compose([Validators.required, Validators.pattern("^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$")])),
      firstName: new FormControl('',Validators.compose([Validators.required, Validators.pattern('^[a-z ]*')])),
      lastName: new FormControl('',Validators.compose([Validators.required,  Validators.pattern('^[a-z ]*')])),
      telephone: new FormControl('',Validators.compose([Validators.required, Validators.pattern('^[1-9 ]*')])),
      password: new FormControl('',Validators.required),
      country:new FormControl('',Validators.required),
      confirm: new FormControl('', Validators.required)
    },{validators:PasswordValidator('password','confirm')})

   
   
 // this.comCountry.getShowCountry().subscribe(
   // (con:Array<Country>)=> this.listItems=con)
 }
  AddUser(){
    console.log("hola");
    //if(this.myform.valid)
    //{
     
      
      const u = new User();
      u.FirstName= this.myform.controls.firstName.value;
      u.LastName= this.myform.controls.lastName.value;
      u.Email= this.myform.controls.email.value;
      u.PhoneNumber= this.myform.controls.telephone.value;
      u.Password= this.myform.controls.password.value;
      u.Country=this.myform.controls.country.value;
    this.dataService.addUser(u).subscribe(
    res=>{if(res== true){console.log(res),
      this.login.setCurrentUser(u);
      this.router.navigate(['/home']);}
      else {
        alert("ese mail ya esta registrado")
        this.myform.reset();
      }
    },
  err=>{console.log(err)}
   )
  //}
}
  
}
