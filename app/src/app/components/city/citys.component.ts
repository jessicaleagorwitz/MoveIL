import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { City } from 'src/app/shared/models/City.model';
import { CityService } from 'src/app/shared/services/city.service';


@Component({
  selector: 'app-citys',
  templateUrl: './citys.component.html',
  styleUrls: ['./citys.component.css']
})
export class CitysComponent implements OnInit {
 
  search
List: City[]
allCity: City[]
  constructor(private cityService: CityService, private router: Router, private SpinnerService: NgxSpinnerService) { 
    this.SpinnerService.show();
    this.cityService.getShowCity().subscribe(
      res=> {this.List=res; this.allCity=res
         this.SpinnerService.hide();  
      }
      ,
      err=>console.log(err)
      
      );
     
  }

  ngOnInit(): void {
  

   // this.cityService.getShowCity().subscribe((con:Array<City>)=>{ this.List=con; console.log(this.List)})
  }
  goToCity(code){
    this.router.navigate(['/yourCity', code]);
  }

  goToSearch(){
   
  //  for(var city of this.allCity){
   //   if(city.CityName.indexOf(this.search)!=-1)
  //    this.List.push(city)
  //  }
    this.List=this.allCity.filter(q=> q.CityName.indexOf(this.search)!=-1)


    
  }
}
