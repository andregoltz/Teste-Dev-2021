import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { DatePipe } from '@angular/common'

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ClientsComponent } from './clients/clients.component';
import { ClientDataService } from './_data-service/client.data-service';
import { UserDataService } from './_data-service/user.data-service';
import { ClientEditionComponent } from './client-edition/client-edition.component';
import { AppRoutingModule } from './app-routing.module';
import { UserComponent } from './user/user.component';
import { Interceptor } from './app.interceptor.module';
import { AuthService } from './user/auth.service';
import { TelephoneDataService } from './_data-service/telephone.data-service';
import { TelephoneComponent } from './telephone/telephone.component';
import { Overlay, OverlayContainer, ToastrModule, ToastrService } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ClientsComponent,
    ClientEditionComponent,
    UserComponent,
    TelephoneComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    CommonModule ,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ToastrModule.forRoot({
      timeOut: 1000,
      progressBar: true,
      progressAnimation: 'increasing',
      preventDuplicates: true
    }),
    RouterModule.forRoot([
      { path: '', component: UserComponent, pathMatch: 'full' },
      { path: 'clients', component: ClientsComponent },
      { path: 'clients/client-edition', component: ClientEditionComponent },
      { path: 'home', component: HomeComponent },
      { path: 'telephone', component: TelephoneComponent }
    ]),
    AppRoutingModule,
    Interceptor
  ],
  providers: [ClientDataService, UserDataService, DatePipe, NavMenuComponent,AuthService,ToastrService,Overlay,OverlayContainer, TelephoneDataService,UserComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
