import { NgModule } from '@angular/core';

import { Routes, RouterModule } from '@angular/router';
import { AddComunityContactsComponent } from './components/add-comunity-contacts/add-comunity-contacts.component';
import { ComunityPageComponent } from './components/comunityPage/comunityPage.component';
import { AliaComponent } from './components/alia/alia.component';

import { CitysComponent } from './components/city/citys.component';
import { HomeComponent } from './components/home/home.component';     // Add your component here
import { LoginComponent } from './components/login/login.component';  // Add your component here
import { MasaComponent } from './components/masa/masa.component';
import { MonumentosComponent } from './components/distritos/monumentos.component';
import { RecomendationComponent} from './components/recomendation/recomendation.component';
import { RegisterComponent } from './components/register/register.component';
import { SearchComponent } from './components/search/search.component';

import { YourCityComponent } from './components/your-city/your-city.component';
import { Recommendation } from './shared/models/Recommendation.model';
import { AddNewComunityComponent } from './components/add-new-comunity/add-new-comunity.component';
import { AddRepresentanteComponent } from './components/add-representante/add-representante.component';
import { DirectiveComponent } from './components/directive/directive.component';
import { AllUsersComponent } from './components/all-users/all-users.component';
import { SearchCityComponent } from './components/search-city/search-city.component';
import { InformationComponent } from './components/information/information.component';
import { AddCityComponent } from './components/add-city/add-city.component';


const routes: Routes = [
    {path: 'home' , component: HomeComponent},
   
   
    {path: 'login', component: LoginComponent},
  
    {path: 'citys', component: CitysComponent},
    {path: 'recomendation', component: RecomendationComponent},
    {path: 'monumentos', component: MonumentosComponent},
    {path: 'search', component: SearchComponent},
    {path: 'masa', component: MasaComponent},
    {path: 'alia', component: AliaComponent},
    {path: 'register', component: RegisterComponent},
    {path: 'yourCity/:code', component: YourCityComponent},
    {path: 'comunityPage/:code', component: ComunityPageComponent},
    {path: 'addComunity', component: AddNewComunityComponent},
    {path: 'addContact', component: AddComunityContactsComponent},
    {path: 'addRep', component: AddRepresentanteComponent},
    {path: 'directive', component: DirectiveComponent},
    {path: 'allUsers', component: AllUsersComponent},
    {path: 'information', component: InformationComponent},
    {path: 'addCity', component: AddCityComponent},
    {path: 'searchCity', component: SearchCityComponent},
    {path: '', redirectTo:'/home', pathMatch:'full'},
  // {path: '**' , component: ErrorComponent},
  ];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }