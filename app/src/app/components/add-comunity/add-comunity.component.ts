import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { City } from 'src/app/shared/models/City.model';
import { Comunity } from 'src/app/shared/models/Comunity.model';
import { Distrito } from 'src/app/shared/models/Distrito.model';
import { Representante } from 'src/app/shared/models/Representante';
import { Sector } from 'src/app/shared/models/Sector.model';
import { CityService } from 'src/app/shared/services/city.service';
import { ComunityService } from 'src/app/shared/services/comunity.service';


@Component({
  selector: 'app-add-comunity',
  templateUrl: './add-comunity.component.html',
  styleUrls: ['./add-comunity.component.css']
})
export class AddComunityComponent implements OnInit {
comunity: Comunity;
code;
representante: Representante= new Representante()
city: City
name;
sector;
sec: Sector
  constructor(private comService: ComunityService, private route :ActivatedRoute, private cityService: CityService) { }

  ngOnInit(): void {
    const Code= this.route.snapshot.paramMap.get('code');
    this.comService.getYourComunity(Code).subscribe(
      res=> {this.comunity=res
      this.code=this.comunity.RepresentanteCode;
      this.getRepresentante(this.code);
       this.cityService.getYourCity(this.comunity.CityCode).subscribe(
       res=> {this.city=res
      console.log(res.CityName);
      this.name=res.CityName;
      },
       err=> console.log(err)
       
     )
     this.comService.getSector(this.comunity.SectorCode).subscribe(
      res=> { this.sec= res
     console.log(res.SectorName);
     },
      err=> console.log(err)
      
    )
      },
      err=>console.log(err)
      
      )   
      
}
getRepresentante(code){
        this.comService.getRepresentante(code).subscribe(
        res=>this.representante=res,
        err=>console.log(err)
      ) 
      }


}

