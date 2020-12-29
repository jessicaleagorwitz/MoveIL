import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Recommendation } from 'src/app/shared/models/Recommendation.model';
import { DataService } from 'src/app/shared/services/data.service';
import { LoginService } from 'src/app/shared/services/login.service';

@Component({
  selector: 'app-recomendation',
  templateUrl: './recomendation.component.html',
  styleUrls: ['./recomendation.component.css']
})
export class RecomendationComponent implements OnInit {

  constructor(private login: LoginService, private data: DataService, private router: Router) { }
Form:FormGroup 
message="necesitas estar registrado"
  ngOnInit(): void {
    if (this.login.IsLogin == false) {
      alert(this.message)
      this.router.navigate(['/home']);
    }
    this.Form= new FormGroup({
      text:new FormControl('', Validators.required)
    })
  }
  
  submit(){
    if(this.Form.valid){
       const r= new Recommendation()
    r.user=this.login.CurrnetUser
    const r2= new Recommendation()
    r2.UserCode= r.user.UserCode
    r2.FreeDescription= this.Form.controls.text.value
    this.data.addRecommendation(r2).subscribe(
      res=>{console.log(res)
        this.router.navigate(['/home']);
      },
      err=> console.log(err)  
    )
    }
   
  }
}
