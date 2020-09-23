import { NgModule } from '@angular/core';

import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';     // Add your component here
import { LoginComponent } from './components/login/login.component';  // Add your component here

const routes: Routes = [
    {path: 'home' , component: HomeComponent},
   
   
    {path: 'login', component: LoginComponent},
    {path: '', redirectTo:'/home', pathMatch:'full'},
  //  {path: '**' , component: ErrorComponent},
  ];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }