import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import { AddComunityComponent } from './components/add-comunity/add-comunity.component';
import { AddComunityContactsComponent } from './components/add-comunity-contacts/add-comunity-contacts.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component'
import { AppRoutingModule } from './app-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ComunityContactsService } from './shared/services/comunity-contacts.service';
@NgModule({
  declarations: [
    AppComponent,
    AddComunityComponent,
    AddComunityContactsComponent,
    HomeComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
     HttpClientModule,
      AppRoutingModule,
      ReactiveFormsModule,
      FormsModule 
  ],
  providers: [ComunityContactsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
