import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { City } from 'src/app/shared/models/City.model';
import { Distrito } from 'src/app/shared/models/Distrito.model';
import {DistritoService} from '../../shared/services/distrito.service'
@Component({
  selector: 'app-monumentos',
  templateUrl: './monumentos.component.html',
  styleUrls: ['./monumentos.component.css']
})
export class MonumentosComponent implements OnInit {
List: Distrito[]

  constructor(private disService: DistritoService, private router: Router ) { 
    this.disService.getDistrito().subscribe(
      res=>{this.List=res 
        console.log(this.List);
        
        this.List.forEach(q=> this.disService.getDistritoCode(q.DistritoCode).subscribe(
          
          res=> {q.city=res
            console.log(this.List);
            
          }
        ))
      },
      err=> console.log(err)
      
    )
  }

  ngOnInit(): void {

  }
  goToCity(code){
    this.router.navigate(['/yourCity', code]);
  }
}
