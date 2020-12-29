import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { City } from 'src/app/shared/models/City.model';
import { Comunity } from 'src/app/shared/models/Comunity.model';
import { Distrito } from 'src/app/shared/models/Distrito.model';
import { Representante } from 'src/app/shared/models/Representante';
import { CityService } from 'src/app/shared/services/city.service';
import { ComunityService } from 'src/app/shared/services/comunity.service';


@Component({
  selector: 'app-add-comunity',
  templateUrl: './add-comunity.component.html',
  styleUrls: ['./add-comunity.component.css']
})
export class AddComunityComponent implements OnInit {
comunity: Comunity= new Comunity()
code;
representante: Representante= new Representante()
city: City= new City()
  constructor(private comService: ComunityService, private route :ActivatedRoute, private cityService: CityService) { }

  ngOnInit(): void {
    const Code= this.route.snapshot.paramMap.get('codeComunity');
    this.comService.getYourComunity(Code).subscribe(
      res=> {this.comunity=res},
      err=>console.log(err)
      
      )
      
  
this.code=this.comunity.RepresentanteCode;

     this.cityService.getYourCity(this.comunity.CityCode).subscribe(
       res=> res=this.city
     )
      this.getRepresentante(this.code);
}
getRepresentante(code){
        this.comService.getRepresentante(code).subscribe(
        res=>this.representante=res,
        err=>console.log(err)
      ) 
      }


}

