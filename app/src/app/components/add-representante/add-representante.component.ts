import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Representante } from 'src/app/shared/models/Representante';
import { ComunityService } from 'src/app/shared/services/comunity.service';

@Component({
  selector: 'app-add-representante',
  templateUrl: './add-representante.component.html',
  styleUrls: ['./add-representante.component.css']
})
export class AddRepresentanteComponent implements OnInit {
myForm: FormGroup
  constructor(private comunityService: ComunityService, private router: Router) { }

  ngOnInit(): void {
    this.myForm = new FormGroup({
      name: new FormControl('', Validators.compose([Validators.required])),
      mail: new FormControl('', Validators.compose([Validators.required])),
      phone: new FormControl('', Validators.compose([Validators.required]))
    });
  }
  addRepresentante() {
    if (this.myForm.valid) {
      const rep= new Representante(); 
      rep.Name = this.myForm.controls.name.value
      rep.Email=this.myForm.controls.mail.value
      rep.PhoneNumber = this.myForm.controls.phone.value
     
      this.comunityService.AddRepresentant(rep).subscribe(
        res=> {console.log(res), this.router.navigate(['/addComunity']); },
        err=> console.log(err)  
      )
     
    }
  }
}
