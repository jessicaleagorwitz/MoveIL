import { NgModule } from '@angular/core';

import { Routes, RouterModule } from '@angular/router';
import { AddComunityComponent } from './components/add-comunity/add-comunity.component';
import { AliaComponent } from './components/alia/alia.component';

import { CitysComponent } from './components/city/citys.component';
import { HomeComponent } from './components/home/home.component';     // Add your component here
import { LoginComponent } from './components/login/login.component';  // Add your component here
import { MasaComponent } from './components/masa/masa.component';
import { MonumentosComponent } from './components/monumentos/monumentos.component';
import { RecomendationComponent} from './components/recomendation/recomendation.component';
import { RegisterComponent } from './components/register/register.component';
import { SearchComponent } from './components/search/search.component';

import { YourCityComponent } from './components/your-city/your-city.component';
import { Recommendation } from './shared/models/Recommendation.model';

const routes: Routes = [
    {path: 'home' , component: HomeComponent},
   
   
    {path: 'login', component: LoginComponent},
    {path: 'add-comunity', component: AddComunityComponent},
    {path: 'citys', component: CitysComponent},
    {path: 'recomendation', component: RecomendationComponent},
    {path: 'monumentos', component: MonumentosComponent},
    {path: 'search', component: SearchComponent},
    {path: 'masa', component: MasaComponent},
    {path: 'alia', component: AliaComponent},
    {path: 'register', component: RegisterComponent},
    {path: 'yourCity/:code', component: YourCityComponent},
    {path: '', redirectTo:'/home', pathMatch:'full'},
  // {path: '**' , component: ErrorComponent},
  ];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }