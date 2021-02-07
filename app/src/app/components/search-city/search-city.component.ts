import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { City } from 'src/app/shared/models/City.model';
import { CityStatus } from 'src/app/shared/models/CityStatus.model';
import { CityService } from 'src/app/shared/services/city.service';
import { LoginService } from 'src/app/shared/services/login.service';

@Component({
  selector: 'app-search-city',
  templateUrl: './search-city.component.html',
  styleUrls: ['./search-city.component.css']
})
export class SearchCityComponent implements OnInit {
  personalStatus: CityStatus=new CityStatus()
  message="you need to do login"
    myForm: FormGroup;
    codeCity: number
    comList: City[]
    city: City=new City()
  constructor(private cityService: CityService, private router: Router, private login: LoginService) { }
  form = new FormGroup({
    precioApt: new FormControl('', Validators.required),
    distrito: new FormControl('', Validators.required),
    poblacion: new FormControl('', Validators.required)
  });

  get f(){
    return this.form.controls;
  }
  ngOnInit(): void {
   // if (this.login.IsLogin == false) {
    //  alert(this.message)
    //  this.router.navigate(['/home']);
    //}
  }
  submit(){
    const p= new CityStatus();
    p.precioApt=this.form.controls.precioApt.value;
    p.distrito=this.form.controls.distrito.value;
    p.poblacion=this.form.controls.poblacion.value;
this.cityService.getSearchCity(p).subscribe(
  res=> this.comList=res,
  err=> console.log(err)
)

}

get r(){
  return this.form.controls;
}


goToCity(code){
 
 
 this.router.navigate(['/yourCity', code]);
}

}
