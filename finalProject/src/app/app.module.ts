import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { RouterModule, Routes, ROUTES } from '@angular/router';
import { AppComponent } from './app.component';
import { CalendarModule } from '@syncfusion/ej2-angular-calendars';
import { HeaderComponent } from '../components/Header/header.component';
import { HomePageComponent } from '../components/Homepage/homepage.component';
import { MenuPageComponent } from '../components/Menupage/menupage.component';
import { ContactUsComponent } from '../components/Contactus/contactus.component';
import { NavComponent } from '../components/Nav/nav.component';
import { SideNavComponent } from '../components/side-nav/side-nav.component';
import { ReviewsComponent } from '../components/Reviews/reviews.component';
import { ReservationComponent } from '../components/Reservation/reservation.component';


const routes: Routes = [
    { path: '', component: HomePageComponent },
    { path: 'contactus', component: ContactUsComponent },
    { path: 'menu', component: MenuPageComponent },
    { path: 'reviews', component: ReviewsComponent },
    { path: 'reservations', component: ReservationComponent },
]; 

@NgModule({
    declarations: [
        AppComponent, HeaderComponent, HomePageComponent, MenuPageComponent, 
        ContactUsComponent, NavComponent, SideNavComponent, ReviewsComponent, 
        ReservationComponent, 
  ],
  imports: [
      BrowserModule,
      RouterModule.forRoot(routes),
      HttpClientModule,CalendarModule 
    ],
     
  exports: [RouterModule],
      
  
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
