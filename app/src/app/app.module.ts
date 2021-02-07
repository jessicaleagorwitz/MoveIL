import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { CollapseModule, WavesModule } from 'angular-bootstrap-md'
//import { MatStepperModule, MatInputModule, MatButtonModule, MatAutocompleteModule } from '@angular/material';
import { NgxSpinnerModule } from "ngx-spinner"; 



import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import {  ComunityPageComponent } from './components/comunityPage/comunityPage.component';
import { AddComunityContactsComponent } from './components/add-comunity-contacts/add-comunity-contacts.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component'
import { AppRoutingModule } from './app-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ComunityContactsService } from './shared/services/comunity-contacts.service';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';
import { BrowserAnimationsModule, NoopAnimationsModule } from '@angular/platform-browser/animations';
import { CitysComponent } from './components/city/citys.component';
import { RecomendationComponent } from './components/recomendation/recomendation.component';
import { MonumentosComponent } from './components/distritos/monumentos.component';
import { SearchComponent } from './components/search/search.component';
import { AliaComponent } from './components/alia/alia.component';
import { MasaComponent } from './components/masa/masa.component';
import { RegisterComponent } from './components/register/register.component';

import { from } from 'rxjs';
import { YourCityComponent } from './components/your-city/your-city.component';
import { AddNewComunityComponent } from './components/add-new-comunity/add-new-comunity.component';
import { DirectiveComponent } from './components/directive/directive.component';
import { AddRepresentanteComponent } from './components/add-representante/add-representante.component';
import { AllUsersComponent } from './components/all-users/all-users.component';
import { SearchCityComponent } from './components/search-city/search-city.component';
import { InformationComponent } from './components/information/information.component';
import { AddCityComponent } from './components/add-city/add-city.component';





@NgModule({
  declarations: [
    AppComponent,
   
    AddComunityContactsComponent,
    HomeComponent,
    LoginComponent,
    CitysComponent,
   RecomendationComponent,
    MonumentosComponent,
    SearchComponent,
    AliaComponent,
    MasaComponent,
    RegisterComponent,
    YourCityComponent,
    ComunityPageComponent,
    AddNewComunityComponent,
    DirectiveComponent,
    AddRepresentanteComponent,
    AllUsersComponent,
    SearchCityComponent,
    InformationComponent,
    AddCityComponent,
   

  ],
  imports: [
    BrowserModule,
     HttpClientModule,
      AppRoutingModule,
      ReactiveFormsModule,
      FormsModule,
      DropDownsModule,
      BrowserAnimationsModule ,
      DropDownsModule,
      NgbModule,
      MDBBootstrapModule.forRoot(),
      CollapseModule,
      WavesModule,
      NoopAnimationsModule,
  
      NgxSpinnerModule 
      
  ],
  providers: [ComunityContactsService],
  bootstrap: [AppComponent],
  
})
export class AppModule { }
