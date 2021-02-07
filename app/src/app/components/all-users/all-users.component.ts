import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/shared/services/data.service';

@Component({
  selector: 'app-all-users',
  templateUrl: './all-users.component.html',
  styleUrls: ['./all-users.component.css']
})
export class AllUsersComponent implements OnInit {
allUsers; 
  constructor(private UserService: DataService) { }

  ngOnInit(): void {
    this.UserService.getAllUsers().subscribe(
      res=>{this.allUsers=res},
      err=> console.log(err) 
    )
  }

}
