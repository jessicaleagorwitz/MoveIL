import { Component, OnInit } from '@angular/core';
import { Comunity } from 'src/app/shared/models/Comunity.model';
import { ComunityService } from 'src/app/shared/services/comunity.service';

@Component({
  selector: 'app-add-comunity',
  templateUrl: './add-comunity.component.html',
  styleUrls: ['./add-comunity.component.css']
})
export class AddComunityComponent implements OnInit {
comunity: Comunity= new Comunity()
  constructor(private comService: ComunityService) { }

  ngOnInit(): void {
    this.comunity.ComunityName='jerusalem';
    this.comunity.SinagogueName='ahavat sion';
    this.AddComunity();
    //this.comServise.getNumComunities

    

  }
  AddComunity(){
    this.comService.AddComunity(this.comunity).subscribe(
       res=>{console.log(res);
        err=>{console.log(err);
        }
       },
    )
   

  }

}
