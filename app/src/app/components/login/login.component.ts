import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators  } from '@angular/forms';
import { DataService } from 'src/app/shared/services/data.service';
import { Distrito } from 'src/app/shared/models/Distrito.model';
import { User } from 'src/app/shared/models/User.model';
import { log } from 'src/app/shared/models/login.model';
import { LoginService } from 'src/app/shared/services/login.service';
import { Router } from '@angular/router';



@Component({
  selector: 'app-login', 
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm;
  loggedIn;
  failedMessage = false;
  chech: boolean
  u: User= new User()
  constructor(private dataService: DataService, private login: LoginService, private router: Router) { }

  ngOnInit(): void {
  
   this.loginForm = new FormGroup({
      email: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required)
    });
  }

 checkUser() {
   if(this.loginForm.valid){
   const l = new log();
  l.Email = this.loginForm.controls.email.value;
  l.Password = this.loginForm.controls.password.value;
   this.dataService.checkUser(l).subscribe(
    res=>{
      if(res!=null){
      this.login.setCurrentUser(res);
      this.router.navigate(['/home']);
    }
    else{
      this.login.setCurrentUser(undefined);
    this.failedMessage = true;
    this.loginForm.reset();
    alert("no existe ese user")
    }
      
    },
  
  err=>{console.log(err)
    
  }  
   )
}
else alert("rellenar el login")
 }
 logOut(){
  this.login.setCurrentUser(undefined);
  this.loggedIn=this.login.IsLogin;
}
  
 
}


