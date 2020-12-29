import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Comunity } from 'src/app/shared/models/Comunity.model';
import { PersonalStatus } from 'src/app/shared/models/PersonalStatus.model';
import { ComunityService } from 'src/app/shared/services/comunity.service';

@Component({
  selector: 'app-masa',
  templateUrl: './masa.component.html',
  styleUrls: ['./masa.component.css']
})
export class MasaComponent implements OnInit {
comList: Comunity[]
  constructor(private comService: ComunityService) { }
  form = new FormGroup({
    quiensoy: new FormControl('', Validators.required),
    economico: new FormControl('', Validators.required),
    religion: new FormControl('', Validators.required)
  });
   
  get f(){
    return this.form.controls;
  }
   
  
 
 
  ngOnInit(): void {
  }
submit(){
  
  
  const p= new PersonalStatus();
    p.quiensoy=this.form.controls.quiensoy.value;
    p.StatusEconomico=this.form.controls.economico.value;
    p.religion=this.form.controls.religion.value;
    console.log(p);
this.comService.getComunity(p).subscribe(
  res=> this.comList=res,
  err=> console.log(err)
)
}
  }

