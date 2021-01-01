import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';

import { City } from 'src/app/shared/models/City.model';
import { Contacts } from 'src/app/shared/models/Contacts.model';
import { CityService } from 'src/app/shared/services/city.service';
import { DataService } from 'src/app/shared/services/data.service';

@Component({
  selector: 'app-your-city',
  templateUrl: './your-city.component.html',
  styleUrls: ['./your-city.component.css']
})
export class YourCityComponent implements OnInit {
code;
MyCity: City;
contacts: Contacts[]

//cityCode:number, CityName:string, DistritoCode:number,  Poblacion:string, AlquilerCentro:string, AlquilerAfueras:string, SalarioMinimo:string,AboutCity:string
    constructor(private cityService: CityService,  private cService: CityService, private _route:ActivatedRoute) { 
    
    }
 

  ngOnInit(): void {
    
   const CityCode= this._route.snapshot.paramMap.get('code');
 
  this.cityService.getYourCity(CityCode).subscribe(
        res=> {this.MyCity=res},
        err=>console.log(err)
        )


        console.log(this.MyCity);
    
  this.code=CityCode
 
        console.log(this.contacts);
        this.getContacts(CityCode);
  }
  getContacts(code){
          this.cService.getContacts(code).subscribe(
          res=>this.contacts=res,
          err=>console.log(err)
        ) 
        }

}
