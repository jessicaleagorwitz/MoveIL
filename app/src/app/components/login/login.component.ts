import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators  } from '@angular/forms';
import {  checkPass } from 'src/app/validators/valid';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  myform:FormGroup;
  constructor() { }

  ngOnInit(): void {
    this.myform= new FormGroup({
      userName: new FormControl('',Validators.compose([Validators.required, Validators.pattern('^[a-z ]*')])),
      firstName: new FormControl('',Validators.compose([Validators.required, Validators.pattern('^[a-z ]*')])),
      lastName: new FormControl('',Validators.compose([Validators.required, Validators.minLength(8)])),
     country: new FormControl('',Validators.compose([Validators.required, Validators.pattern('^[a-z ]*')])),
     Email: new FormControl('',Validators.required),
      telephone: new FormControl('',Validators.compose([Validators.required, Validators.pattern('^[1-9 ]*')])),
      accept: new FormControl('', Validators.requiredTrue),
      password: new FormControl('',Validators.required),
      confirm: new FormControl('', Validators.required)
    },{validators:checkPass('password','confirm')})
  }
  }


