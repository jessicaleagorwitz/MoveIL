
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { Comunity } from 'src/app/shared/models/Comunity.model';
import { PersonalStatus } from 'src/app/shared/models/PersonalStatus.model';
import { ComunityService } from 'src/app/shared/services/comunity.service';
import { LoginService } from 'src/app/shared/services/login.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
 
})
export class SearchComponent  implements OnInit  {
 
personalStatus: PersonalStatus=new PersonalStatus()
message="you need to do login"
  myForm: FormGroup;
  codeComunity: number
  comList: Comunity[]
  comunity: Comunity=new Comunity()
  constructor(private comService: ComunityService, private router: Router, private login: LoginService) { }


  form = new FormGroup({
    quiensoy: new FormControl('', Validators.required),
    economico: new FormControl('', Validators.required),
    religion: new FormControl('', Validators.required)
  });
   
  get f(){
    return this.form.controls;
  }
  ngOnInit(): void {
    if (this.login.IsLogin == false) {
      alert(this.message)
      this.router.navigate(['/home']);
    }
  }
  searchComunity(){
    const p= new PersonalStatus();
    p.quiensoy=this.myForm.controls.quiensoy.value;
    p.StatusEconomico=this.myForm.controls.economico.value;
    p.religion=this.myForm.controls.religion.value;
this.comService.getComunity(p).subscribe(
  res=> this.comList=res,
  err=> console.log(err)
)
this.myForm = new FormGroup({
 quiensoy: new FormControl('', Validators.required),
  economico: new FormControl('',Validators.required),
  religion: new FormControl('', Validators.required)
});
}
goToComunity(){
 
  this.router.navigate(['/add-comunity', this.codeComunity]);
}
get r(){
  return this.form.controls;
}

submit(){
  const p= new PersonalStatus();
    p.quiensoy=this.form.controls.quiensoy.value;
    p.StatusEconomico=this.form.controls.economico.value;
    console.log(p.StatusEconomico);
    
    p.religion=this.form.controls.religion.value;
    console.log(p);
this.comService.getComunity(p).subscribe(
  res=>{this.comList=res,
console.log(this.comList)}
,
  err=> console.log(err)
)
}
}