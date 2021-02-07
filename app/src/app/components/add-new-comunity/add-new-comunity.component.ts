import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { City } from 'src/app/shared/models/City.model';
import { Comunity } from 'src/app/shared/models/Comunity.model';
import { Costo } from 'src/app/shared/models/Costo.model';
import { Representante } from 'src/app/shared/models/Representante';
import { Sector } from 'src/app/shared/models/Sector.model';
import { CityService } from 'src/app/shared/services/city.service';
import { ComunityService } from 'src/app/shared/services/comunity.service';

@Component({
  selector: 'app-add-new-comunity',
  templateUrl: './add-new-comunity.component.html',
  styleUrls: ['./add-new-comunity.component.css']
})
export class AddNewComunityComponent implements OnInit {
  allSector: Sector[];
  allCosto: Costo[];
  allRepresentante: Representante[];
  allCity: City[];
  myForm: FormGroup;
  constructor(private cityService: CityService, private comunityService: ComunityService, private router: Router) { }

  ngOnInit(): void {
    this.comunityService.getAllCosto().subscribe(
      res=> this.allCosto=res,
      err=>console.log(err)
    )
   this.comunityService.getAllRepresentantes().subscribe(
     res=> this.allRepresentante=res,
     err=> console.log(err)  
   )

   this.comunityService.getAllSectors().subscribe(
     res=> this.allSector=res,
     err=> console.log(err)  
   )
   this.cityService.getShowCity().subscribe(
     res=>this.allCity=res,
     err=> console.log(err) 
   )
    this.myForm = new FormGroup({
      name: new FormControl('', Validators.compose([Validators.required])),
      sectorCode: new FormControl('', Validators.required),
      costoCode: new FormControl('', Validators.required),
      cityCode: new FormControl('', Validators.required),
      representanteCode: new FormControl('', Validators.required),
      anciano: new FormControl('', Validators.required),
      about: new FormControl('', Validators.required)
    });
  }
  addComunity() {
    if (this.myForm.valid) {
      const comunity = new Comunity(); 
      comunity.ComunityName = this.myForm.controls.name.value
      comunity.CityCode=this.myForm.controls.cityCode.value
      comunity.CostoCode = this.myForm.controls.costoCode.value
      comunity.RepresentanteCode = this.myForm.controls.representanteCode.value;
      comunity.SectorCode = this.myForm.controls.sectorCode.value;
      comunity.anciano = this.myForm.controls.anciano.value;
      comunity.About = this.myForm.controls.about.value;
      this.comunityService.AddComunity(comunity).subscribe(
        res=> {console.log(res),
          this.router.navigate(['/directive']);},
        err=> console.log(err)  
      )
      this.router.navigate(['/directive']);
    }
  }
}
