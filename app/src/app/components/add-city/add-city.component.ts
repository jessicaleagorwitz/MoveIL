import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { City } from 'src/app/shared/models/City.model';
import { Distrito } from 'src/app/shared/models/Distrito.model';
import { CityService } from 'src/app/shared/services/city.service';
import { DistritoService } from 'src/app/shared/services/distrito.service';

@Component({
  selector: 'app-add-city',
  templateUrl: './add-city.component.html',
  styleUrls: ['./add-city.component.css']
})
export class AddCityComponent implements OnInit {
alldis: Distrito[]
myForm: FormGroup
  constructor(private disService: DistritoService, private cityService: CityService, private router: Router) { }

  ngOnInit(): void {
    this.disService.getDistrito().subscribe(
      res=>this.alldis=res,
      err=> console.log(err) 
    )

    this.myForm = new FormGroup({
      city: new FormControl('',Validators.required),
      distritoCode: new FormControl('', Validators.required),
      pobla: new FormControl('', Validators.required),
      alquilerCentro: new FormControl('', Validators.required),
      alquilerAfuera: new FormControl('', Validators.required),
      salario: new FormControl('', Validators.required),
      about: new FormControl('', Validators.required)
    });
  }

  addCity() {
    if (this.myForm.valid) {
      const con = new City(); 
      con.CityName = this.myForm.controls.city.value
      con.DistritoCode=this.myForm.controls.distritoCode.value
      con.Poblacion = this.myForm.controls.pobla.value
      con.AlquilerAfueras = this.myForm.controls.alquilerAfuera.value;
      con.AlquilerCentro= this.myForm.controls.alquilerCentro.value;
      con.SalarioMinimo = this.myForm.controls.salario.value;
      con.AboutCity = this.myForm.controls.about.value;
      this.cityService.addCity(con).subscribe(
        res=> {console.log(res),
          this.router.navigate(['/directive']);
        },
        err=> console.log(err)  
      )
      this.router.navigate(['/directive']);
    }
  }

}
